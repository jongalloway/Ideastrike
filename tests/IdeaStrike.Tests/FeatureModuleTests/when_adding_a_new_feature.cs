using Ideastrike.Nancy.Models;
using Moq;
using Xunit;

namespace IdeaStrike.Tests.FeatureModuleTests
{
    // TODO: test that unauthenticated user cannot access resource

    public class when_adding_a_new_feature : IdeaStrikeSpecBase
    {
        public when_adding_a_new_feature()
        {
            testResponse = browser.Post("/idea/0/feature", with => {
                with.LoggedInUser(CreateMockUser("shiftkey"));
            });
        }

        [Fact]
        public void it_should_add_the_new_feature()
        {
            mockFeatureRepo.Verify(B => B.Add(0,It.IsAny<Feature>()));
        }
    }
}