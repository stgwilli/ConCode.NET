﻿using System.Linq;
using ConCode.NET.Core.Domain;
using CodeConf.NET.Core.Data;

namespace CodeConf.NET.Core.Domain
{
    public class SessionService : ISessionService
    {
        private IConferenceDataProvider _conferenceDataProvider;

        public SessionService(IConferenceDataProvider conferenceDataProvider)
        {
            _conferenceDataProvider = conferenceDataProvider;
        }

        public IQueryable<Session> GetSessions()
        {
            return _conferenceDataProvider.Sessions;
        }
    }
}
