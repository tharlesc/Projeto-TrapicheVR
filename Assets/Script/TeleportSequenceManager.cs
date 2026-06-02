using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;

public class TeleportSequenceManager : MonoBehaviour
{
    [Header("Configurações do Teletransporte")]
    [Tooltip("Arraste o Teleportation Provider que está no seu XR Origin")]
    public TeleportationProvider teleportationProvider;

    [Tooltip("Coloque aqui as suas Teleport Anchors na ordem dos botões do painel")]
    public TeleportationAnchor[] anchors;

    /// <summary>
    /// Função para teletransportar para um índice específico da lista
    /// </summary>
    /// <param name="anchorIndex">O número do ponto (começando em 0)</param>
    public void TeleportToSpecificAnchor(int anchorIndex)
    {
        if (teleportationProvider == null || anchors == null || anchors.Length == 0)
        {
            Debug.LogWarning("TeleportSequenceManager: Falta configurar as referências no Inspector!");
            return;
        }

        // Verifica se o índice enviado pelo botão existe na lista de âncoras
        if (anchorIndex < 0 || anchorIndex >= anchors.Length)
        {
            Debug.LogError($"TeleportSequenceManager: O índice {anchorIndex} não existe na lista de Âncoras!");
            return;
        }

        TeleportationAnchor targetAnchor = anchors[anchorIndex];

        if (targetAnchor != null)
        {
            TeleportRequest request = new TeleportRequest()
            {
                destinationPosition = targetAnchor.teleportAnchorTransform.position,
                destinationRotation = targetAnchor.teleportAnchorTransform.rotation,
                matchOrientation = MatchOrientation.TargetUpAndForward
            };

            teleportationProvider.QueueTeleportRequest(request);
        }
    }
}