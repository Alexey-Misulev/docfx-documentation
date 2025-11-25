using UnityEngine;

/// <summary>
/// Пример класса для документации.
/// </summary>
public class ExampleClass : MonoBehaviour
{
    public float aaa;
    public float bbb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
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
