// Interfaz Command
public interface ICommand
{
    void Execute();
}
// Receptor: Light
public class Light
{
    public void TurnOn()
    {
        Console.WriteLine("The light is ON");
    }

    public void TurnOff()
    {
        Console.WriteLine("The light is OFF");
    }
}
// Comando concreto para encender la luz
public class TurnOnLightCommand : ICommand
{
    private Light _light;

    public TurnOnLightCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOn();
    }
}

// Comando concreto para apagar la luz
public class TurnOffLightCommand : ICommand
{
    private Light _light;

    public TurnOffLightCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOff();
    }
}
// Invocador: RemoteControl
public class RemoteControl
{
    private ICommand _command;

    // Establece el comando
    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    // Ejecuta el comando
    public void PressButton()
    {
        _command.Execute();
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Crear el receptor
        Light livingRoomLight = new Light();

        // Crear los comandos concretos
        ICommand turnOnLight = new TurnOnLightCommand(livingRoomLight);
        ICommand turnOffLight = new TurnOffLightCommand(livingRoomLight);

        // Crear el invocador
        RemoteControl remote = new RemoteControl();

        // Encender la luz
        remote.SetCommand(turnOnLight);
        remote.PressButton();  // Output: The light is ON

        // Apagar la luz
        remote.SetCommand(turnOffLight);
        remote.PressButton();  // Output: The light is OFF
    }
}
