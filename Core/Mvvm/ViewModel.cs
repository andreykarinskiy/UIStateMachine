using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace Core.Mvvm
{
    public abstract class ViewModel : BindableBase
    {
        private readonly IDictionary<string, object> properties = new Dictionary<string, object>(); 

        protected T Get<T>([CallerMemberName] string propertyName = "")
        {
            object propertyValue;
            if (properties.TryGetValue(propertyName, out propertyValue))
            {
                return (T) propertyValue;
            }

            return default(T);

            //throw new InvalidOperationException($"property {propertyName} not found");
        }

        protected void Set<T>(T propertyValue, [CallerMemberName] string propertyName = "")
        {
            if (properties.ContainsKey(propertyName))
            {
                properties[propertyName] = propertyValue;
            }
            else
            {
                properties.Add(propertyName, propertyValue);
            }

            OnPropertyChanged(propertyName);
        }
    }
}
