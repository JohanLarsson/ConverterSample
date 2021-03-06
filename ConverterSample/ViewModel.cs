﻿namespace ConverterSample
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using ConverterSample.Annotations;

    public class ViewModel : INotifyPropertyChanged
    {
        private int _value;
        public event PropertyChangedEventHandler PropertyChanged;

        public int Value
        {
            get { return _value; }
            set
            {
                if (value == _value) return;
                _value = value;
                OnPropertyChanged();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
