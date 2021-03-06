﻿using ConCode.NET.Core.Data;
using ConCode.NET.Core.Domain;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ConCode.NET.Tests.Core.Domain
{
    public class When_executing_SpeakerService
    {
        private Mock<IConferenceDataProvider> _mockConferenceDataProvider;
        private ISpeakerService _speakerService;
        private IQueryable<Speaker> _speakers;

        public When_executing_SpeakerService()
        {
            _mockConferenceDataProvider = new Mock<IConferenceDataProvider>();
            _mockConferenceDataProvider.Setup(d => d.Speakers).Returns(new List<Speaker> { new Speaker() }.AsQueryable());

            _speakerService = new SpeakerService(_mockConferenceDataProvider.Object);
        }

        [Fact]
        public void Should_return_speakers()
        {
            _speakers = _speakerService.GetSpeakers();

            _mockConferenceDataProvider.Verify(x => x.Speakers);
            Assert.NotEmpty(_speakers);
        }
    }
}
