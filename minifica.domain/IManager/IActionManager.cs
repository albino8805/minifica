using minifica.data.ViewModels;
using ActionEntity = minifica.data.Models.Action;

namespace minifica.domain.IManager
{
    public interface IActionManager: IBaseManager<ActionViewModel, ActionEntity>
    {

    }
}
