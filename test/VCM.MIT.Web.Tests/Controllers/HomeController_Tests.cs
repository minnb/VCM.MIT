using System.Threading.Tasks;
using VCM.MIT.Models.TokenAuth;
using VCM.MIT.Web.Controllers;
using Shouldly;
using Xunit;

namespace VCM.MIT.Web.Tests.Controllers
{
    public class HomeController_Tests: MITWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}