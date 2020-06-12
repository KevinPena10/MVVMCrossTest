using MvvmCross.IoC;
using MvvmCross.ViewModels;
using TipCalculator.Core.ViewModels;

namespace TipCalculator.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service") // Inyección de Dependencias, todo lo que termine en services lo va inyectar
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<TipViewModel>(); //Por donde arranca el proyecto
        }
    }
}
