﻿using System.Collections;
using System.Collections.Generic;


//  BNodeSequence.cs
//  Author: Lu Zexi
//  2014-06-07


namespace Game.AIBehaviorTree
{
    /// <summary>
    /// 顺序节点
    /// </summary>
    public class BNodeSequence : BNodeComposite
    {
        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override bool Excute(BInput input)
        {
            for (int i = 0; i < this.m_lstChildren.Count; i++)
            {
                if (!this.m_lstChildren[i].Excute(input))
                    return false;
            }
            return true;
        }
    }
}