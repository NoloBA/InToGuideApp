using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace InToGuideApp.ViewModels
{
    public class IntroductionPageViewModel : ViewModelBase
    {
        int _position;
        public int ImagePosition
        {
            get { return _position; }
            set { SetProperty(ref _position, value); }
        }

        //define list item source
        //List<string> _carouselImages;
        //public List<string> CarouselImages
        //{
        //    get { return _carouselImages; }
        //    set { SetProperty(ref _carouselImages, value); }
        //}
        //public ObservableCollection<Image> CarouselImages


        //define selected list item
        //string _image;
        //public string Image
        //{
        //    get { return _image; }
        //    set { SetProperty(ref _image, value); }
        //}

       
        
        public IntroductionPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            //Device.StartTimer(TimeSpan.FromSeconds(3), (Func<bool>)(() =>
            //{
            //    ImagePosition = (ImagePosition + 1) % 3;
            //    return true;
            //}));
            //CarouselImages = new List<string>
            //{
            //    new Image= "slide1.png";
            //    new Image("slide2.png"), 
            //    new Image("slide3.png"),
            //};
        }
        
        public override void Initialize(INavigationParameters parameters)
        {
            Title = "Introduction";

        }
        private DelegateCommand _introductionCommand;
        public DelegateCommand IntroductionCommand =>
            _introductionCommand ?? (_introductionCommand = new DelegateCommand(ExecuteIntroductionCommand));

        private async void ExecuteIntroductionCommand()
        {
            await NavigationService.NavigateAsync("WelcomePage");

        }


    }
}
