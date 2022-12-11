using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

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
        this._decryptedText = string.Empty;
        for (var i = 65; i < 91; ++i)
        {
            this._dictionary.Add(Convert.ToChar(i).ToString(), string.Empty);
        }
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
                this.DecryptText();
            }
        }
    }

    /// <summary>
    /// Decrypted text.
    /// </summary>
    public string DecryptedText
    {
        get => this._decryptedText;
        set
        {
            if (this.SetField(ref this._decryptedText, value))
            {
                // TODO
            }
        }
    }

    /// <summary />
    public string LetterA
    {
        get => this._dictionary["A"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["A"] == validValue) return;
            this._dictionary["A"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterB
    {
        get => this._dictionary["B"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["B"] == validValue) return;
            this._dictionary["B"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterC
    {
        get => this._dictionary["C"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["C"] == validValue) return;
            this._dictionary["C"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterD
    {
        get => this._dictionary["D"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["D"] == validValue) return;
            this._dictionary["D"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterE
    {
        get => this._dictionary["E"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["E"] == validValue) return;
            this._dictionary["E"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterF
    {
        get => this._dictionary["F"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["F"] == validValue) return;
            this._dictionary["F"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterG
    {
        get => this._dictionary["G"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["G"] == validValue) return;
            this._dictionary["G"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterH
    {
        get => this._dictionary["H"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["H"] == validValue) return;
            this._dictionary["H"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterI
    {
        get => this._dictionary["I"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["I"] == validValue) return;
            this._dictionary["I"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterJ
    {
        get => this._dictionary["J"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["J"] == validValue) return;
            this._dictionary["J"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterK
    {
        get => this._dictionary["K"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["K"] == validValue) return;
            this._dictionary["K"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterL
    {
        get => this._dictionary["L"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["L"] == validValue) return;
            this._dictionary["L"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterM
    {
        get => this._dictionary["M"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["M"] == validValue) return;
            this._dictionary["M"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterN
    {
        get => this._dictionary["N"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["N"] == validValue) return;
            this._dictionary["N"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterO
    {
        get => this._dictionary["O"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["O"] == validValue) return;
            this._dictionary["O"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterP
    {
        get => this._dictionary["P"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["P"] == validValue) return;
            this._dictionary["P"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterQ
    {
        get => this._dictionary["Q"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["Q"] == validValue) return;
            this._dictionary["Q"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterR
    {
        get => this._dictionary["R"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["R"] == validValue) return;
            this._dictionary["R"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterS
    {
        get => this._dictionary["S"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["S"] == validValue) return;
            this._dictionary["S"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterT
    {
        get => this._dictionary["T"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["T"] == validValue) return;
            this._dictionary["T"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterU
    {
        get => this._dictionary["U"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["U"] == validValue) return;
            this._dictionary["U"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterV
    {
        get => this._dictionary["V"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["V"] == validValue) return;
            this._dictionary["V"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterW
    {
        get => this._dictionary["W"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["W"] == validValue) return;
            this._dictionary["W"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterX
    {
        get => this._dictionary["X"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["X"] == validValue) return;
            this._dictionary["X"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterY
    {
        get => this._dictionary["Y"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["Y"] == validValue) return;
            this._dictionary["Y"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    /// <summary />
    public string LetterZ
    {
        get => this._dictionary["Z"];
        set
        {
            var validValue = ValidateLetter(value);
            if (this._dictionary["Z"] == validValue) return;
            this._dictionary["Z"] = validValue;
            this.OnPropertyChanged();
            this.DecryptText();
        }
    }

    private static string ValidateLetter(string letter)
    {
        if (string.IsNullOrWhiteSpace(letter))
        {
            return string.Empty;
        }

        if (letter.Length > 1)
        {
            letter = letter[..1];
        }

        letter = letter.ToUpperInvariant();
        return 'A' <= letter[0] && letter[0] <= 'Z'
            ? letter
            : string.Empty;
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

    private void DecryptText()
    {
        var builder = new StringBuilder();
        foreach (var letter in this._encryptedText)
        {
            if ('A' <= letter && letter <= 'Z')
            {
                var mapped = this._dictionary[letter.ToString()];
                if (string.IsNullOrWhiteSpace(mapped))
                {
                    builder.Append('_');
                }
                else
                {
                    builder.Append(mapped);
                }
            }
            else
            {
                builder.Append(letter);
            }
        }

        this.DecryptedText = builder.ToString();
    }

    private string _encryptedText;
    private string _decryptedText;
    private readonly Dictionary<string, string> _dictionary = new();
}
