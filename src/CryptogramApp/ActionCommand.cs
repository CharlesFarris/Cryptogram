using System.Windows.Input;

namespace SleepingBearSystem.Cryptogram.CryptogramApp;

/// <summary>
/// Command for handling simple actions.
/// </summary>
public sealed class ActionCommand : ICommand
{
    /// <summary>
    /// Constructor.
    /// </summary>
    public ActionCommand(Action<object?> action, Func<object?, bool>? canExecute = default)
    {
        this._action = action ?? throw new ArgumentNullException(nameof(action));
        this._canExecute = canExecute ?? (_ => true);
    }

    /// <inheritdoc cref="ICommand"/>.
    public bool CanExecute(object? parameter) => this._canExecute.Invoke(parameter);

    /// <inheritdoc cref="ICommand"/>.
    public void Execute(object? parameter) => this._action.Invoke(parameter);

    /// <inheritdoc cref="ICommand"/>.
    public event EventHandler? CanExecuteChanged;

    private readonly Action<object?> _action;

    private readonly Func<object?, bool> _canExecute;
}
