
using FormDemo.Models;

namespace FormDemo.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string valueimput;

        [ObservableProperty]
        private List<Billdata> _billdata;

        public MainViewModel()
        {
            _billdata = initbilldata();
        }

        private List<Billdata> initbilldata()
        {
            return new List<Billdata> {
                new Billdata { code="Código: CVEFT0001", value="Valor: 869$00", issuedate="D/h: "+DateTime.Now.ToString("d")},
                new Billdata { code="Código: CVEFT0002", value="Valor: 286$00", issuedate="D/h: "+DateTime.Now.ToString("d")},
                new Billdata { code="Código: CVEFT0003", value="Valor: 56$00", issuedate="D/h: "+DateTime.Now.ToString("d")},
                new Billdata { code="Código: CVEFT0004", value="Valor: 586$00", issuedate="D/h: "+DateTime.Now.ToString("d")},
                new Billdata { code="Código: CVEFT0005", value="Valor: 200$00", issuedate="D/h: " + DateTime.Now.ToString("d")},
                 new Billdata { code="Código: CVEFT0006", value="Valor: 869$00", issuedate="D/h: "+DateTime.Now.ToString("d")},
                new Billdata { code="Código: CVEFT0007", value="Valor: 286$00", issuedate="D/h: "+DateTime.Now.ToString("d")},
                new Billdata { code="Código: CVEFT0008", value="Valor: 56$00", issuedate="D/h: "+DateTime.Now.ToString("d")},
                new Billdata { code="Código: CVEFT0009", value="Valor: 586$00", issuedate="D/h: "+DateTime.Now.ToString("d")},
                new Billdata { code="Código: CVEFT00010", value="Valor: 345$00", issuedate="D/h: " + DateTime.Now.ToString("d")}
            };
        }

    }
}
