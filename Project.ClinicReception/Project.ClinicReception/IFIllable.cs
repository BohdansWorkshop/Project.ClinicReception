using System.Collections.Generic;

namespace ClinicReception.UserInterface.UserControls
{
    public interface IFillable
    {
        void FillControl(Dictionary<string, int> columns, string[][] elements);
    }

    public delegate void CallbackRefresh(IFillable control);
}