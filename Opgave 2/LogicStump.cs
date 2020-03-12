using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Opgave_2
{
    // This is NOT a Logic tier.
    // It is at Logic stump (no connection to a Data tier) wich can be used ONLY to test the Presentation tier.
    // Test login is: social security number "999999-0000" and password "testpw"
    public class Logic
    {
        private List<DTO_Weight> weightList_;
        private List<DTO_BSugar> bsList_;
        private List<DTO_BPressure> bpList_;
      
        public Logic()
        {
            bsList_ = new List<DTO_BSugar>();
            LoadBSList();
            bpList_ = new List<DTO_BPressure>();
            LoadBTList();
            weightList_ = new List<DTO_Weight>();
            LoadVægtList();
            
        }

        public bool checkLogin( String socSecNb, String pw )
        {

            return (socSecNb == "999999-0000" && pw == "test" ||
                socSecNb == "123456-7890" && pw == "1234" ||
                socSecNb == "234567-8901" && pw == "2345" ||
                socSecNb == "345678-9012" && pw == "3456" ||
                socSecNb == "250497-5555" && pw == "3076");


        }

        public List<DTO_Weight> getWeightAndBMIData(string id)
        {
            return weightList_;
        }

        public List<DTO_BSugar> getBSugarData(string id)
        {
            return bsList_;
        }

        public List<DTO_BPressure> getBPressureData(/*string id*/)
        {
            return bpList_;
        }

        // These 3 methods will NOT be present in the real Logic tier
        private void LoadBSList()
        {
            bsList_.Add(new DTO_BSugar(6.5, new DateTime(2015, 1, 30, 8, 0, 0)));
            bsList_.Add(new DTO_BSugar(5.6, new DateTime(2015, 1, 30, 12, 30, 0)));
            bsList_.Add(new DTO_BSugar(11.5, new DateTime(2015, 1, 30, 18, 45, 0)));
            bsList_.Add(new DTO_BSugar(3.7, new DateTime(2015, 1, 30, 22, 15, 0)));
            bsList_.Add(new DTO_BSugar(6.4, new DateTime(2015, 1, 31, 8, 0, 0)));
            bsList_.Add(new DTO_BSugar(6.0, new DateTime(2015, 1, 31, 15, 22, 0)));
            bsList_.Add(new DTO_BSugar(7.9, new DateTime(2015, 2, 1, 8, 0, 0)));
            bsList_.Add(new DTO_BSugar(4.8, new DateTime(2015, 2, 1, 10, 30, 0)));
            bsList_.Add(new DTO_BSugar(15.3, new DateTime(2015, 2, 1, 21, 0, 0)));
            bsList_.Add(new DTO_BSugar(6.2, new DateTime(2015, 2, 2, 8, 15, 0)));
        }
        
            
        

    private void LoadBTList()
        {
            bpList_.Add(new DTO_BPressure(120, 80, new DateTime(2015, 1, 30, 8, 0, 0)));
            bpList_.Add(new DTO_BPressure(110, 75, new DateTime(2015, 1, 31, 8, 0, 0)));
            bpList_.Add(new DTO_BPressure(140, 95, new DateTime(2015, 2, 10, 18, 37, 0)));
            bpList_.Add(new DTO_BPressure(115, 90, new DateTime(2015, 2, 12, 18, 37, 0)));
            bpList_.Add(new DTO_BPressure(120, 85, new DateTime(2015, 2, 15, 18, 37, 0)));
        }

        private void LoadVægtList()
        {
            weightList_.Add(new DTO_Weight(86.5, 24, new DateTime(2015, 1, 30, 8, 0, 0)));
            weightList_.Add(new DTO_Weight(86.9, 25, new DateTime(2015, 1, 30, 18, 0, 0)));
            weightList_.Add(new DTO_Weight(87.0, 26, new DateTime(2015, 1, 31, 8, 0, 0)));
            weightList_.Add(new DTO_Weight(85.5, 23, new DateTime(2015, 2, 1, 8, 0, 0)));
        }
   
    }
}