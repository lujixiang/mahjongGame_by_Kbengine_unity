/*
	Generated by KBEngine!
	Please do not modify this file!
	Please inherit this module, such as: (class Account : AccountBase)
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	// defined in */scripts/entity_defs/Account.def
	// Please inherit and implement "class Account : AccountBase"
	public abstract class AccountBase : Entity
	{
		public EntityBaseEntityCall_AccountBase baseEntityCall = null;
		public EntityCellEntityCall_AccountBase cellEntityCall = null;

		public Byte isNewPlayer = 1;
		public virtual void onIsNewPlayerChanged(Byte oldValue) {}
		public Byte isReady = 0;
		public virtual void onIsReadyChanged(Byte oldValue) {}
		public UInt16 playerID = 0;
		public virtual void onPlayerIDChanged(UInt16 oldValue) {}
		public UInt16 playerID_base = 0;
		public virtual void onPlayerID_baseChanged(UInt16 oldValue) {}
		public string playerName = "";
		public virtual void onPlayerNameChanged(string oldValue) {}
		public string playerName_base = "";
		public virtual void onPlayerName_baseChanged(string oldValue) {}
		public Byte roomSeatIndex = 0;
		public virtual void onRoomSeatIndexChanged(Byte oldValue) {}

		public abstract void OnReqCreateAvatar(Byte arg1); 
		public abstract void onGetRoomInfo(ROOM_PUBLIC_INFO arg1); 
		public abstract void playerLevelRoom(); 

		public AccountBase()
		{
		}

		public override void onGetBase()
		{
			baseEntityCall = new EntityBaseEntityCall_AccountBase(id, className);
		}

		public override void onGetCell()
		{
			cellEntityCall = new EntityCellEntityCall_AccountBase(id, className);
		}

		public override void onLoseCell()
		{
			cellEntityCall = null;
		}

		public override EntityCall getBaseEntityCall()
		{
			return baseEntityCall;
		}

		public override EntityCall getCellEntityCall()
		{
			return cellEntityCall;
		}

		public override void onRemoteMethodCall(MemoryStream stream)
		{
			ScriptModule sm = EntityDef.moduledefs["Account"];

			UInt16 methodUtype = 0;
			UInt16 componentPropertyUType = 0;

			if(sm.useMethodDescrAlias)
			{
				componentPropertyUType = stream.readUint8();
				methodUtype = stream.readUint8();
			}
			else
			{
				componentPropertyUType = stream.readUint16();
				methodUtype = stream.readUint16();
			}

			Method method = null;

			if(componentPropertyUType == 0)
			{
				method = sm.idmethods[methodUtype];
			}
			else
			{
				Property pComponentPropertyDescription = sm.idpropertys[componentPropertyUType];
				switch(pComponentPropertyDescription.properUtype)
				{
					default:
						break;
				}

				return;
			}

			switch(method.methodUtype)
			{
				case 12:
					Byte OnReqCreateAvatar_arg1 = stream.readUint8();
					OnReqCreateAvatar(OnReqCreateAvatar_arg1);
					break;
				case 14:
					ROOM_PUBLIC_INFO onGetRoomInfo_arg1 = ((DATATYPE_ROOM_PUBLIC_INFO)method.args[0]).createFromStreamEx(stream);
					onGetRoomInfo(onGetRoomInfo_arg1);
					break;
				case 13:
					playerLevelRoom();
					break;
				default:
					break;
			};
		}

		public override void onUpdatePropertys(MemoryStream stream)
		{
			ScriptModule sm = EntityDef.moduledefs["Account"];
			Dictionary<UInt16, Property> pdatas = sm.idpropertys;

			while(stream.length() > 0)
			{
				UInt16 _t_utype = 0;
				UInt16 _t_child_utype = 0;

				{
					if(sm.usePropertyDescrAlias)
					{
						_t_utype = stream.readUint8();
						_t_child_utype = stream.readUint8();
					}
					else
					{
						_t_utype = stream.readUint16();
						_t_child_utype = stream.readUint16();
					}
				}

				Property prop = null;

				if(_t_utype == 0)
				{
					prop = pdatas[_t_child_utype];
				}
				else
				{
					Property pComponentPropertyDescription = pdatas[_t_utype];
					switch(pComponentPropertyDescription.properUtype)
					{
						default:
							break;
					}

					return;
				}

				switch(prop.properUtype)
				{
					case 40001:
						Vector3 oldval_direction = direction;
						direction = stream.readVector3();

						if(prop.isBase())
						{
							if(inited)
								onDirectionChanged(oldval_direction);
						}
						else
						{
							if(inWorld)
								onDirectionChanged(oldval_direction);
						}

						break;
					case 5:
						Byte oldval_isNewPlayer = isNewPlayer;
						isNewPlayer = stream.readUint8();

						if(prop.isBase())
						{
							if(inited)
								onIsNewPlayerChanged(oldval_isNewPlayer);
						}
						else
						{
							if(inWorld)
								onIsNewPlayerChanged(oldval_isNewPlayer);
						}

						break;
					case 7:
						Byte oldval_isReady = isReady;
						isReady = stream.readUint8();

						if(prop.isBase())
						{
							if(inited)
								onIsReadyChanged(oldval_isReady);
						}
						else
						{
							if(inWorld)
								onIsReadyChanged(oldval_isReady);
						}

						break;
					case 4:
						UInt16 oldval_playerID = playerID;
						playerID = stream.readUint16();

						if(prop.isBase())
						{
							if(inited)
								onPlayerIDChanged(oldval_playerID);
						}
						else
						{
							if(inWorld)
								onPlayerIDChanged(oldval_playerID);
						}

						break;
					case 2:
						UInt16 oldval_playerID_base = playerID_base;
						playerID_base = stream.readUint16();

						if(prop.isBase())
						{
							if(inited)
								onPlayerID_baseChanged(oldval_playerID_base);
						}
						else
						{
							if(inWorld)
								onPlayerID_baseChanged(oldval_playerID_base);
						}

						break;
					case 3:
						string oldval_playerName = playerName;
						playerName = stream.readUnicode();

						if(prop.isBase())
						{
							if(inited)
								onPlayerNameChanged(oldval_playerName);
						}
						else
						{
							if(inWorld)
								onPlayerNameChanged(oldval_playerName);
						}

						break;
					case 1:
						string oldval_playerName_base = playerName_base;
						playerName_base = stream.readUnicode();

						if(prop.isBase())
						{
							if(inited)
								onPlayerName_baseChanged(oldval_playerName_base);
						}
						else
						{
							if(inWorld)
								onPlayerName_baseChanged(oldval_playerName_base);
						}

						break;
					case 40000:
						Vector3 oldval_position = position;
						position = stream.readVector3();

						if(prop.isBase())
						{
							if(inited)
								onPositionChanged(oldval_position);
						}
						else
						{
							if(inWorld)
								onPositionChanged(oldval_position);
						}

						break;
					case 6:
						Byte oldval_roomSeatIndex = roomSeatIndex;
						roomSeatIndex = stream.readUint8();

						if(prop.isBase())
						{
							if(inited)
								onRoomSeatIndexChanged(oldval_roomSeatIndex);
						}
						else
						{
							if(inWorld)
								onRoomSeatIndexChanged(oldval_roomSeatIndex);
						}

						break;
					case 40002:
						stream.readUint32();
						break;
					default:
						break;
				};
			}
		}

		public override void callPropertysSetMethods()
		{
			ScriptModule sm = EntityDef.moduledefs["Account"];
			Dictionary<UInt16, Property> pdatas = sm.idpropertys;

			Vector3 oldval_direction = direction;
			Property prop_direction = pdatas[2];
			if(prop_direction.isBase())
			{
				if(inited && !inWorld)
					onDirectionChanged(oldval_direction);
			}
			else
			{
				if(inWorld)
				{
					if(prop_direction.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onDirectionChanged(oldval_direction);
					}
				}
			}

			Byte oldval_isNewPlayer = isNewPlayer;
			Property prop_isNewPlayer = pdatas[4];
			if(prop_isNewPlayer.isBase())
			{
				if(inited && !inWorld)
					onIsNewPlayerChanged(oldval_isNewPlayer);
			}
			else
			{
				if(inWorld)
				{
					if(prop_isNewPlayer.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onIsNewPlayerChanged(oldval_isNewPlayer);
					}
				}
			}

			Byte oldval_isReady = isReady;
			Property prop_isReady = pdatas[5];
			if(prop_isReady.isBase())
			{
				if(inited && !inWorld)
					onIsReadyChanged(oldval_isReady);
			}
			else
			{
				if(inWorld)
				{
					if(prop_isReady.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onIsReadyChanged(oldval_isReady);
					}
				}
			}

			UInt16 oldval_playerID = playerID;
			Property prop_playerID = pdatas[6];
			if(prop_playerID.isBase())
			{
				if(inited && !inWorld)
					onPlayerIDChanged(oldval_playerID);
			}
			else
			{
				if(inWorld)
				{
					if(prop_playerID.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onPlayerIDChanged(oldval_playerID);
					}
				}
			}

			UInt16 oldval_playerID_base = playerID_base;
			Property prop_playerID_base = pdatas[7];
			if(prop_playerID_base.isBase())
			{
				if(inited && !inWorld)
					onPlayerID_baseChanged(oldval_playerID_base);
			}
			else
			{
				if(inWorld)
				{
					if(prop_playerID_base.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onPlayerID_baseChanged(oldval_playerID_base);
					}
				}
			}

			string oldval_playerName = playerName;
			Property prop_playerName = pdatas[8];
			if(prop_playerName.isBase())
			{
				if(inited && !inWorld)
					onPlayerNameChanged(oldval_playerName);
			}
			else
			{
				if(inWorld)
				{
					if(prop_playerName.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onPlayerNameChanged(oldval_playerName);
					}
				}
			}

			string oldval_playerName_base = playerName_base;
			Property prop_playerName_base = pdatas[9];
			if(prop_playerName_base.isBase())
			{
				if(inited && !inWorld)
					onPlayerName_baseChanged(oldval_playerName_base);
			}
			else
			{
				if(inWorld)
				{
					if(prop_playerName_base.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onPlayerName_baseChanged(oldval_playerName_base);
					}
				}
			}

			Vector3 oldval_position = position;
			Property prop_position = pdatas[1];
			if(prop_position.isBase())
			{
				if(inited && !inWorld)
					onPositionChanged(oldval_position);
			}
			else
			{
				if(inWorld)
				{
					if(prop_position.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onPositionChanged(oldval_position);
					}
				}
			}

			Byte oldval_roomSeatIndex = roomSeatIndex;
			Property prop_roomSeatIndex = pdatas[10];
			if(prop_roomSeatIndex.isBase())
			{
				if(inited && !inWorld)
					onRoomSeatIndexChanged(oldval_roomSeatIndex);
			}
			else
			{
				if(inWorld)
				{
					if(prop_roomSeatIndex.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onRoomSeatIndexChanged(oldval_roomSeatIndex);
					}
				}
			}

		}
	}
}