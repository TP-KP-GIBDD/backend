using AutoMapper;
using Microsoft.Extensions.Options;
using Registration.Entities;
using Registration.Helpers;
using Registration.Models.Accounts;
using Registration.Models.Docs;
using Registration.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registration.Services
{
    public class DocService : IDocService
    {
        //private readonly DataContext _context;
        //private readonly IMapper _mapper;
        //private readonly AppSettings _appSettings;
        //private readonly IEmailService _emailService;

        //public DocService(
        //   DataContext context,
        //   IMapper mapper,
        //   IOptions<AppSettings> appSettings,
        //   IEmailService emailService)
        //{
        //    _context = context;
        //    _mapper = mapper;
        //    _appSettings = appSettings.Value;
        //    _emailService = emailService;
        //}

        //public void AddDriverLicence(DriverLicenceRequest model, string origin)
        //{
        //    if ( (_context.Data.Any(x => x.SeriesDriverLicence == model.SeriesDriverLicence)) && (_context.Data.Any(x => x.NumberDriverLicence == model.NumberDriverLicence)))
        //    {
        //        throw new AppException($"Driver licence '{model.SeriesDriverLicence}' '{model.NumberDriverLicence}' is used");
        //    }
        //    var data = _mapper.Map<Data>(model);
        //    data.SeriesDriverLicence = model.SeriesDriverLicence;
        //    data.NumberDriverLicence = model.NumberDriverLicence;
        //    data.DateIssueDriverLicence = model.DateIssueDriverLicence;
        //    data.ValidityPeriodDriverLicence = model.ValidityPeriodDriverLicence;

        //    _context.Data.Add(data);
        //    _context.SaveChanges();

        //}

        //public void AddIdentityCard(IdentityCardRequest model, string origin)
        //{
        //    if (_context.Data.Any(x => x.NumberIdentityCard == model.NumberIdentityCard))
        //    {
        //        throw new AppException($"Identity card '{model.NumberIdentityCard}' is used");
        //    }
        //    var data = _mapper.Map<Data>(model);
        //    data.NumberIdentityCard = model.NumberIdentityCard;

        //    _context.Data.Add(data);
        //    _context.SaveChanges();
        //}

        //public void AddPassport(PassportRequest model, string origin)
        //{
        //    if ((_context.Data.Any(x => x.SeriesPassport == model.SeriesPassport)) && (_context.Data.Any(x => x.NumberPassport == model.NumberPassport)))
        //    {
        //        throw new AppException($"Passport '{model.SeriesPassport}' '{model.NumberPassport}' is used");
        //    }
        //    var data = _mapper.Map<Data>(model);
        //    data.Address = model.Address;
        //    data.SeriesPassport = model.SeriesPassport;
        //    data.NumberPassport = model.NumberPassport;
        //    data.DateIssuePassport = model.DateIssuePassport;

        //    _context.Data.Add(data);
        //    _context.SaveChanges();
        //}

        //public DriverLicenceResponce UpdateDriverLicence(int id, DriverLicenceRequest model)
        //{
        //    var data = getData(id);

        //    data.SeriesDriverLicence = model.SeriesDriverLicence;
        //    data.NumberDriverLicence = model.NumberDriverLicence;
        //    data.DateIssueDriverLicence = model.DateIssueDriverLicence;
        //    data.ValidityPeriodDriverLicence = model.ValidityPeriodDriverLicence;

        //    _mapper.Map(model, data);
        //    _context.Data.Update(data);
        //    _context.SaveChanges();

        //    return _mapper.Map<DriverLicenceResponce>(data);
        //}

        //public IdentityCardResponce UpdateIdentityCard(int id, IdentityCardRequest model)
        //{
        //    var data = getData(id);

        //    data.NumberIdentityCard = model.NumberIdentityCard;

        //    _mapper.Map(model, data);
        //    _context.Data.Update(data);
        //    _context.SaveChanges();

        //    return _mapper.Map<IdentityCardResponce>(data);
        //}

        //public PassportResponce UpdatePassport(int id, PassportRequest model)
        //{
        //    var data = getData(id);

        //    data.Address = model.Address;
        //    data.SeriesPassport = model.SeriesPassport;
        //    data.NumberPassport = model.NumberPassport;
        //    data.DateIssuePassport = model.DateIssuePassport;

        //    _mapper.Map(model, data);
        //    _context.Data.Update(data);
        //    _context.SaveChanges();

        //    return _mapper.Map<PassportResponce>(data);
        //}

        //private Data getData( int Id)
        //{
        //    var data = _context.Data.Find(Id);
        //    if (data == null) throw new KeyNotFoundException("Data not found");
        //    return data;
        //} 
        public void AddDriverLicence(DriverLicenceRequest model, string origin)
        {
            throw new NotImplementedException();
        }

        public void AddIdentityCard(IdentityCardRequest model, string origin)
        {
            throw new NotImplementedException();
        }

        public void AddPassport(PassportRequest model, string origin)
        {
            throw new NotImplementedException();
        }

        public DriverLicenceResponce UpdateDriverLicence(int id, DriverLicenceRequest model)
        {
            throw new NotImplementedException();
        }

        public IdentityCardResponce UpdateIdentityCard(int id, IdentityCardRequest model)
        {
            throw new NotImplementedException();
        }

        public PassportResponce UpdatePassport(int id, PassportRequest model)
        {
            throw new NotImplementedException();
        }
    }
}
