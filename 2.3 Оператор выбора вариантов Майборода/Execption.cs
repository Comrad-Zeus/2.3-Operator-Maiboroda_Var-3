// 2.3. Оператор выбора вариантов - Майборода - Вар 3 - Средний Уровень (5)
using System.Runtime.Serialization;

[Serializable]
internal class Execption : Exception
{
    public Execption()
    {
    }

    public Execption(string? message) : base(message)
    {
    }

    public Execption(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected Execption(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}