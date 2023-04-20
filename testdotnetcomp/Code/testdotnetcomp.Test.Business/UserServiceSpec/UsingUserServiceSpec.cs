using NSubstitute;
using testdotnetcomp.Test.Framework;
using testdotnetcomp.BusinessServices.Services;
using testdotnetcomp.Data.Interfaces;

namespace testdotnetcomp.Test.Business.UserServiceSpec
{
    public abstract class UsingUserServiceSpec : SpecFor<UserService>
    {
        protected IUserRepository _userRepository;

        public override void Context()
        {
            _userRepository = Substitute.For<IUserRepository>();
            subject = new UserService(_userRepository);

        }

    }
}