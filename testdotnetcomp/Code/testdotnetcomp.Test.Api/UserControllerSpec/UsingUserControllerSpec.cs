using NSubstitute;
using testdotnetcomp.Test.Framework;
using testdotnetcomp.Api.Controllers;
using testdotnetcomp.BusinessServices.Interfaces;
using AutoMapper;
using testdotnetcomp.BusinessEntities.Entities;
using testdotnetcomp.Contracts.DTO;


namespace testdotnetcomp.Test.Api.UserControllerSpec
{
    public abstract class UsingUserControllerSpec : SpecFor<UserController>
    {
        protected IUserService _userService;
        protected IMapper _mapper;

        public override void Context()
        {
            _userService = Substitute.For<IUserService>();
            _mapper = Substitute.For<IMapper>();
            subject = new UserController(_userService,_mapper);

        }

    }
}
