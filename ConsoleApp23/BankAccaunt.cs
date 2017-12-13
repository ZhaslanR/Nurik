using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public delegate void AccountHadler(string message);

    public class BankAccaunt
    {
        private AccountHadler handler;

        public double Sum { get; private set; }

        public void RegisterHandler(AccountHadler handler)
        {
            Delegate newHandler = Delegate.Combine(handler, this.handler);
            this.handler = newHandler as AccountHadler;
        }

        public void UnRegisterHadler()
        {
            this.handler = null;
        }
        
        public void Add(double sum)
        {
            if(handler != null)
            {
                Sum += sum;
                handler.Invoke("Вы внесли " + sum);
            }
        }

        public void Withdrow(double sum)
        {
            if (sum <= Sum)

            {
                Sum -= sum;
                if (handler != null)
                {
                    handler.Invoke("Вы сняли сл счета " + sum);
                }
            }
            else
            {
                if(handler != null)
                {
                    handler.Invoke("Недостаточна средств");
                }
            }
        }
    }
}
