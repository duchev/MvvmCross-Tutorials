﻿namespace Collections.Core.ViewModels.Samples.LargeFixed
{
    public class LargeFixedViewModel : BaseSampleViewModel
    {        
        private MyCustomList _kittens;
        public MyCustomList Kittens
        {
            get { return _kittens; }
            set { _kittens = value; RaisePropertyChanged(() => Kittens); }
        }

        public LargeFixedViewModel()
        {
            Kittens = new MyCustomList();
        }
    }
}