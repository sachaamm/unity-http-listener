using UnityCustomHttpListener.Scripts.Model;
using UnityCustomHttpListener.Scripts.Utility;

namespace UnityCustomHttpListener.Scripts.Attribute
{
    public class MyRestRouteAttribute : System.Attribute
    {
        
        private string name;
        public string Name => name;

        private HttpRestMethod method;
        public HttpRestMethod Method => method;
        

        private HttpResponseUtility.HttpResponseContentType _contentType;
        public HttpResponseUtility.HttpResponseContentType ContentType => _contentType;

        private string dataKey;
        public string DataKey => dataKey;

        public MyRestRouteAttribute(string name, HttpRestMethod httpRestMethod, HttpResponseUtility.HttpResponseContentType contentType, string key = null)  
        {  
            this.name = name;
            this.method = httpRestMethod;
            _contentType = contentType;
            dataKey = key;


        }
    }
}