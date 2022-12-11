namespace SleepingBearSystems.Cryptogram.Model.Tests;

/// <summary>
/// Test for <see cref="CryptogramModel"/>.
/// </summary>
internal static class CryptogramModelTests
{
    [Test]
    public static void EncryptedText_ValidatesBehavior()
    {
        // create model
        var model = new CryptogramModel();
        Assert.That(model.EncryptedText, Is.Empty);
        var propertyChangedCalled = false;
        model.PropertyChanged += (sender, args) =>
        {
            Assert.That(args.PropertyName, Is.EqualTo("EncryptedText"));
            propertyChangedCalled = true;
        };

        // use case: valid text change
        model.EncryptedText = "The quick brown fox jumped over the lazy dogs.";
        Assert.Multiple(() =>
        {
            Assert.That(model.EncryptedText, Is.EqualTo("The quick brown fox jumped over the lazy dogs."));
            Assert.That(propertyChangedCalled, Is.True);
        });

        // use case: duplicate text
        propertyChangedCalled = false;
        model.EncryptedText = "The quick brown fox jumped over the lazy dogs.";
        Assert.That(propertyChangedCalled, Is.False);

        // use case: null text
        propertyChangedCalled = false;
        model.EncryptedText = null!;
        Assert.Multiple(() =>
        {
            Assert.That(model.EncryptedText, Is.Empty);
            Assert.That(propertyChangedCalled, Is.True);
        });

        // use case: empty text
        propertyChangedCalled = false;
        model.EncryptedText = string.Empty;
        Assert.That(propertyChangedCalled, Is.False);

        // use case: whitespace text
        propertyChangedCalled = false;
        model.EncryptedText = "    ";
        Assert.That(propertyChangedCalled, Is.False);
    }
}
