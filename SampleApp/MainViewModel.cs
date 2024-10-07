using Microsoft.VisualStudio.Imaging.Interop;
using System;
using System.ComponentModel;

namespace SampleApp
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ImageMoniker _sampleImageMoniker;

        public MainViewModel()
        {
            _sampleImageMoniker = new ImageMoniker
            {
                Guid = new Guid("{D5B6C5B8-564B-400A-B81F-3C6BB85C0E22}"),
                Id = 1
            };
        }

        public ImageMoniker SampleImageMoniker
        {
            get { return _sampleImageMoniker; }
            set
            {
                _sampleImageMoniker = value;
                OnPropertyChanged(nameof(SampleImageMoniker));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
