using System;

namespace ClinicReception.UserInterface.UserControls
{
    public interface IEditable
    {
        void Delete(CallbackRefresh refresh, Guid id, IFillable control);
        void Edit(CallbackRefresh refresh, Guid id, IFillable control);
        void Add(CallbackRefresh refresh, IFillable control);
    }
}