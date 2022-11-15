using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMDemo.ViewModels
{
    public class ViewModelOperaciones :ViewModelBase
    {

        int valueA;
        public int ValueA
        {
            get { return valueA; }
            set
            {
                if (value != valueA)
                {
                    valueA = value;
                    OnPropertyChanged();
                }
            }
        }

        int valueB;
        public int ValueB
        {
            get { return valueB; }
            set
            {
                if (value != valueB)
                {
                    valueB = value;
                    OnPropertyChanged();
                }
            }
        }

        string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
            set
            {
                if (value != mensaje)
                {
                    mensaje = value;
                    OnPropertyChanged();
                }
            }
        }

        int answerd;
        public int Answerd
        {
            get { return answerd; }
            set
            {
                if(value != answerd)
                {
                    answerd = value;
                    OnPropertyChanged();
                }
            }
        }

        #region  Atributos
        string message;
        public string Message
        {
            get { return message; }
            set
            {
                if (message != value)
                {
                    message = value;
                    OnPropertyChanged();
                }
            }
        }


        int valorA;
        public int ValorA
        {
            get { return valorA; }
            set
            {
                if (valorA != value)
                {
                    valorA = value;
                    OnPropertyChanged();
                }
            }
        }

        int valorB;
        public int ValorB
        {
            get { return valorB; }
            set
            {
                if (valorB != value)
                {
                    valorB = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoSuma;
        public int ResultadoSuma
        {
            get { return resultadoSuma; }
            set
            {
                if (resultadoSuma != value)
                {
                    resultadoSuma = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        public ICommand Sumar { protected set; get; }
        public ICommand Dividir { protected set; get; }
        public ICommand Restar { protected set; get; }
        public ICommand Multiplicar { protected set; get; }

        
        public ViewModelOperaciones()
        {
            Sumar = new Command(() =>
            {
                Answerd = ValueA + ValueB;
                Mensaje = "";
            });

            Restar = new Command(() =>
            {
                Answerd = ValueA - ValueB;
                Mensaje = "";
            });

            Multiplicar = new Command(() =>
            {
                Answerd = ValueA * ValueB;
                Mensaje = "";
            });

            Dividir = new Command(() =>
            {
                if (ValueB !=0)
                {
                    Answerd = ValueA/ValueB;
                    Mensaje = "";
                }
                else
                {
                    Answerd = 0;
                    Mensaje = "No puedes dividir entre 0";
                }

            });

        }       
    }
}
