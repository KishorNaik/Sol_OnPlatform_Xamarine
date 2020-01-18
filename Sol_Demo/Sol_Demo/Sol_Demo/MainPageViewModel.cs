using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Sol_Demo
{
    public class MainPageViewModel
    {
        #region Constructor
        public MainPageViewModel()
        {
            OnSubmitClick();
        }
        #endregion

        #region Property
        public Command OnSubmit { get; set; }
        #endregion

        #region Method
        public void OnSubmitClick()
        {
            OnSubmit = new Command<ContentPage>((leContentPage) => {

                if (Device.RuntimePlatform == Device.Android)
                {
                    var buttonObj = leContentPage.FindByName<Button>("btnSubmit1");
                    buttonObj.BackgroundColor = Color.Orange;
                }
                else if (Device.RuntimePlatform == Device.iOS)
                { 
                    var buttonObj = leContentPage.FindByName<Button>("btnSubmit1");
                    buttonObj.BackgroundColor = Color.Orange;
                }
            
            });
        }
        #endregion 
    }
}
