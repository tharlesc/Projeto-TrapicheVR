using UnityEngine;

public class RotacionarTextura : MonoBehaviour
{
    public float angulo = 90f;

    void Start()
    {
        // Converte ângulo para Radianos
        float rad = angulo * Mathf.Deg2Rad;
        float cos = Mathf.Cos(rad);
        float sin = Mathf.Sin(rad);

        // Cria uma matriz de rotação simples
        Vector4 rotationMatrix = new Vector4(cos, -sin, sin, cos);
        
        // Aplica ao material (apenas se o shader suportar ou se usar o shader padrão com ST)
        // Nota: O shader Lit padrão da Unity não aceita rotação nativa por Vector4, 
        // por isso o Shader Graph (Opção 1) é o caminho certo no URP.
    }
}