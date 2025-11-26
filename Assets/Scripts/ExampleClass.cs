/// <summary>
/// Пример класса для документации.
/// </summary>
public static class ExampleClass
{
    public float aaa;
    public float bbb;

    /// <summary>
    /// Start
    /// </summary>
    void Start()
    {
        
    }

    /// <summary>
    /// Update
    /// </summary>
    void Update()
    {
        Debug.LogError(Add(aaa, bbb));
    }
    
    /// <summary>
    /// Складывает два числа.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Сумма a и b.</returns>
    public static float Add(float a, float b) => a + b;
}
