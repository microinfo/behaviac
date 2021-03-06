/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Tencent is pleased to support the open source community by making behaviac available.
//
// Copyright (C) 2015 THL A29 Limited, a Tencent company. All rights reserved.
//
// Licensed under the BSD 3-Clause License (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at http://opensource.org/licenses/BSD-3-Clause
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;
using behaviac;
using TNS.NE.NAT;

namespace TNS
{
	namespace NE
	{
		namespace NAT
		{
			[behaviac.TypeMetaInfo("色彩枚举", "eColor 是一个用于测试枚举使用的类型")]
			public enum eColor
			{
				[behaviac.MemberMetaInfo("红色 Red", "Red 是一种非常激进的色彩")]
				RED,	
				GREEN,
				BLUE,	
				YELLOW,	
				WHITE,
			}
		}
	}

	namespace ST
	{
		public struct kCar
		{
			public string	brand;
			public int		price;
			public eColor 	color;

			public void reset()
			{
				brand = "Volkswage";
				price = 0;
				color = eColor.RED;
			}
		}

		namespace PER
		{
			//<
			namespace WRK
			{
				public struct kEmployee
				{
					public int		id;
					public string 	name;
					public char 	code;
					public float 	weight;
					public bool 	isMale;
					public eColor	skinColor;
					public kCar		car;
					public Agent	boss;
					
					public void resetProperties()
					{
						id		= -1;
						name 	= string.Empty;
						code 	= 'A';
						weight	= 0.0f;
						isMale	= true;
						skinColor = eColor.YELLOW;
						car.reset();
						boss	= null;
					}
				}
			}
		}
		//<
	}
}
