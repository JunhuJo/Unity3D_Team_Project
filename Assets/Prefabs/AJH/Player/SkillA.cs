using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillA : StateMachineBehaviour
{
    ColliderScript weaponColliderScript;
    playerAnimator playerAnimator;
    bool isSkillAttack = false;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        playerAnimator = animator.GetComponent<playerAnimator>();
        // 무기의 콜라이더 스크립트를 찾습니다.
        weaponColliderScript = animator.GetComponentInChildren<ColliderScript>();

        // 스킬 공격 상태에 진입했으므로 isSkillAttack 변수를 true로 설정합니다.
        isSkillAttack = true;

        // 충돌 이벤트를 처리하는 메서드를 설정합니다.
        weaponColliderScript.SkillTriggerA += OnTriggerEnterEventHandler;
    }

    // 스킬 공격이 끝나면 isSkillAttack 변수를 false로 설정합니다.
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        playerAnimator = animator.GetComponent<playerAnimator>();
        //playerAnimator.DisableWeapon();

        isSkillAttack = false;
    }

    private void OnTriggerEnterEventHandler(Collider otherCollider)
    {
        // 스킬 공격인 경우
        if (isSkillAttack)
        {
            Debug.Log("Skill Attack detected!");
            // 스킬 공격 처리 코드 추가
        }
        else
        {
            // 일반 공격인 경우
            Debug.Log("Normal Attack detected!");
            // 일반 공격 처리 코드 추가
        }
    }
}
