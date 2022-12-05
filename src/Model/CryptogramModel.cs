using System.ComponentModel;

namespace SleepingBearSystems.Cryptogram.Model;

/// <summary>
/// Model for a cryptogram.
/// </summary>
public sealed class CryptogramModel : INotifyPropertyChanged
{
    /// <summary>
    /// Constructor
    /// </summary>
    public CryptogramModel()
    {
    }

    /// <summary>
    /// Gets and sets the encrypted text.
    /// </summary>
    public string EncryptedText
    {
        get => this._encryptedText;
        set
        {
            var validValue = (value ?? string.Empty).Trim();
            if (validValue != this._encryptedText)
            {
                this._encryptedText = validValue;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.EncryptedText)));
            }
        }
    }

    /// <inheritdoc cref="INotifyPropertyChanged"/>
    public event PropertyChangedEventHandler? PropertyChanged;

    private string _encryptedText = string.Empty;
}
