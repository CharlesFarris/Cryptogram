using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SleepingBearSystem.Cryptogram.CryptogramApp;

/// <summary>
/// Cryptogram View Model.
/// </summary>
public sealed class CryptogramViewModel : INotifyPropertyChanged
{
    /// <summary>
    /// Constructor.
    /// </summary>
    public CryptogramViewModel()
    {
        this._encryptedText = string.Empty;
        this.UpdateCommand = new ActionCommand(this.HandleUpdate);
    }

    /// <inheritdoc cref="INotifyPropertyChanged"/>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Encrypted Text.
    /// </summary>
    public string EncryptedText
    {
        get => this._encryptedText;
        set
        {
            var validValue = (value ?? string.Empty).Trim();
            if (this.SetField(ref this._encryptedText, validValue))
            {
                // TODO
            }
        }
    }

    /// <summary>
    /// Handles updating the encrypted text.
    /// </summary>
    public ICommand UpdateCommand { get; }

    /// <summary>
    /// Handles the Update button click event.
    /// </summary>
    public void HandleUpdate(object? parameter)
    {
        this.EncryptedText = parameter?.ToString() ?? string.Empty;
    }

    /// <inheritdoc cref="INotifyPropertyChanged"/>
    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    /// <inheritdoc cref="INotifyPropertyChanged"/>
    private bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        this.OnPropertyChanged(propertyName);
        return true;
    }

    private string _encryptedText;
}
