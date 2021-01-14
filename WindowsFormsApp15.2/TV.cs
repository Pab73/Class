using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15._2
{
    class TV
    {

        private int _kanaal;
        private int _volume;
        private int Kanaal
        {
            get { return _kanaal; }
            set { _kanaal = value; }
        }
        private int Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }
        public TV()
        {
            _kanaal = 0;
            _volume = 0;
        }
        public string ToonGegevens()
        {
            string eenString = $"Kanaal: {_kanaal} - Volume: {_volume} ";
            return eenString;
        }
        public void VermeerderKanaal()
        {
            if (_kanaal >= 30)
            {
                _kanaal = 30;
            }
            else
            {
                _kanaal++;
            }
        }
        public void VermeerderVolume()
        {
            if (_volume >= 10)
            {
                _volume = 10;
            }
            else
            {
                _volume++;
            }
        }
        public void VerminderKanaal()
        {
            if (_kanaal <= 0)
            {
                _kanaal = 0;
            }
            else
            {
                _kanaal--;
            }
        }
        public void VerminderVolume()
        {
            if (_volume <= 0)
            {
                _volume = 0;
            }
            else
            {
                _volume--;
            }
        }
    }
}
