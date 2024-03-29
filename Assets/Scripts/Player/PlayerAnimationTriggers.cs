using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationTriggers : MonoBehaviour
{
    private Player player => GetComponentInParent<Player>();

    private void AnimationTrigger()
    {
        player.AnimationTrigger();
    }
    private void CreateFire()
    {
        Instantiate(player.bulletFire, player.firePos.position, transform.rotation);
        player.AnimationTrigger();
    }

}
