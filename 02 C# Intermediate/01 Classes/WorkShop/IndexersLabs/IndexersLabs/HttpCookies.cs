using System.Collections.Generic;

namespace IndexersLabs
{
    public class HttpCookies
    {
        private readonly Dictionary<string, string> _cookies = new Dictionary<string, string>();

        public void Fill()
        {
            _cookies.Add("username", "ahedfi");
            _cookies.Add("nationality", "Tunisian");
        }
        public string GetCookie(string key)
        {
            return _cookies[key];
        }
        public void SetCookie(string key, string value)
        {
            if (_cookies.ContainsKey(key))
                _cookies[key] = value;
            else
            {
                _cookies.Add(key, value);
            }
        }

        public string this[string key]
        {
            get { return _cookies[key]; }
            set
            {
                if (_cookies.ContainsKey(key))
                    _cookies[key] = value;
                else
                {
                    _cookies.Add(key, value);
                }
            }
        }
    }
}
