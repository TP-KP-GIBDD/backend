using AutoMapper;
using DTP.Entities;
using DTP.Models;
using DTP.Repositories.Abstracts;
using DTP.Services.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Services
{
    public class ProtocolService : IProtocolService
    {
        private IMapper _mapper;
        private ProtocolContext _context;
        private IProtocolRepository _protocolRepository;

        public ProtocolService(
            ProtocolContext context,
            IMapper mapper,
            IProtocolRepository protocolRepository)
        {
            _context = context;
            _mapper = mapper;
            _protocolRepository = protocolRepository;
        }

        public void Create(ProtocolRequest model)
        {
            Random rand = new Random();

            // Создание конфигурации сопоставления
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProtocolRequest, Coordinates>()
                    .ForMember("Latitube", opt => opt.MapFrom(a => a.Latitube))
                    .ForMember("Longitube", opt => opt.MapFrom(b => b.Longitube)));
            // Настройка AutoMapper
            _mapper = new Mapper(config);
            // сопоставление
            var coordinates = _mapper.Map<ProtocolRequest, Coordinates>(model);

            _context.Coordinates.Add(coordinates);
            _context.SaveChanges();

            config = new MapperConfiguration(cfg =>  cfg.CreateMap<ProtocolRequest, PlaceViolation>()
                    .ForMember("TypeLighting", opt => opt.MapFrom(a => a.TypeLighting))
                    .ForMember("RoadSigns", opt => opt.MapFrom(b => b.RoadSigns))
                    .ForMember("MethodTrafficRegulation", opt => opt.MapFrom(c => c.MethodTrafficRegulation))
                    .ForMember("RoadMarkup", opt => opt.MapFrom(d => d.RoadMarkup))
                    );
            // Настройка AutoMapper
            _mapper = new Mapper(config);
            // сопоставление
            var place = _mapper.Map<ProtocolRequest, PlaceViolation>(model);

            place.CoordinatesId = coordinates.Id;
            _context.PlaceViolation.Add(place);
            _context.SaveChanges();

            config = new MapperConfiguration(cfg => cfg.CreateMap<ProtocolRequest, Participants>()
                  .ForMember("AccountId", opt => opt.MapFrom(a => a.AccountId))
                  .ForMember("Status", opt => opt.MapFrom(b => b.Status))
                  );
            // Настройка AutoMapper
            _mapper = new Mapper(config);
            // сопоставление
            var participant = _mapper.Map<ProtocolRequest, Participants>(model);
            _context.Participants.Add(participant);
            _context.SaveChanges();

            config = new MapperConfiguration(cfg => cfg.CreateMap<ProtocolRequest, Protocol>()
                  .ForMember("TypeViolationId", opt => opt.MapFrom(a => a.TypeViolationId))
                  .ForMember("Address", opt => opt.MapFrom(b => b.Address))
                  .ForMember("dateTime", opt => opt.MapFrom(c => c.dateTime))
                  .ForMember("InspectorId", opt => opt.MapFrom(d => d.InspectorId))
                  .ForMember("Violation", opt => opt.MapFrom(e => e.Violation))
                  .ForMember("AvtoId", opt => opt.MapFrom(f => f.AvtoId))
                  .ForMember("Damage", opt => opt.MapFrom(g => g.Damage))
                  );
            // Настройка AutoMapper
            _mapper = new Mapper(config);
            // сопоставление
            var protocol = _mapper.Map<ProtocolRequest, Protocol>(model);

            protocol.identifier = rand.Next(1, 10001);
            protocol.PlaceViolationId = place.Id;
            protocol.ParticipantsId = participant.Id;
            _context.Protocols.Add(protocol);
            _context.SaveChanges();

        }

        public async Task<IEnumerable<Protocol>> GetAll()
        {
            return await _protocolRepository.GetAll();
        }

        public async Task<IEnumerable<Protocol>> GetProtocolByIdentifier(int identifier)
        {
            return await _protocolRepository.GetProtocolByIdentifier(identifier);
        }

        public async Task<IEnumerable<Protocol>> GetProtocolByInspector(int inspectorId)
        {
            return await _protocolRepository.GetProtocolByInspector(inspectorId);
        }

        public async Task<IEnumerable<Protocol>> GetProtocolByAvto(int avtoId)
        {
            return await _protocolRepository.GetProtocolByAvto(avtoId);
        }

        public async Task<IEnumerable<Protocol>>GetProtocolByTypeViolation(int violationId)
        {
            return await _protocolRepository.GetProtocolByTypeViolation(violationId);
        }

        public async Task<Protocol> GetProtocolById(int Id)
        {
            return await _protocolRepository.GetAsync(Id);
        }

    }
}
