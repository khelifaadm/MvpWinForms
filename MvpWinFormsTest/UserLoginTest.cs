using Moq;
using MvpWinForms.Presenter;
using MvpWinForms.View;
using System;
using Xunit;

namespace MvpWinFormsTest
{
    public class UserLoginTest
    {
        [Fact]
        public void Login_Always_ReturnFalse()
        {
            //Arrange
            var view = new Mock<IUserLoginView>();
            var presenter = new UserLoginPresenter(view.Object);
            //Act
            bool actual = presenter.Login();
            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void Login_Always_GotError()
        { 
            //Arrange
            var mock = new Mock<IUserLoginView>();
            var presenter = new UserLoginPresenter(mock.Object);
            mock.SetupSet(m => m.Error = "Wrong Credential").Verifiable();
            //Act
            bool actual = presenter.Login();
            //Assert
            mock.Verify();
        }

    }
}
