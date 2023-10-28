using Fluxor;

namespace FluxorTestAspNet8.Stores;


[FeatureState]
public record AppState
{
    public string LastMessage { get; set; } = "None yet";

}

public record SendMessageToConsole(string Message) { };



public static class AppReducers
{
    [ReducerMethod]
    public static AppState SendMessageToConsole(AppState state, SendMessageToConsole action)
    => state with
    {
        LastMessage = action.Message
    };


}

public class AppEffects
{

    [EffectMethod]
    public async Task SendMessageToConsole(SendMessageToConsole action, IDispatcher dispatcher)
    {
        Console.WriteLine(action.Message);  
    }

}

