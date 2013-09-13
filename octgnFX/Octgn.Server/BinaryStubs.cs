﻿/* 
 * This file was automatically generated by MyGeneration! (from BinarySender.zeus)
 * Do not modify, changes will get lost when the file is regenerated!
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;

namespace Octgn.Server
{
	abstract class BaseBinaryStub : Octgn.Server.IClientCalls
	{
	    private Handler handler;
	    
	    public BaseBinaryStub(Handler handler)
	    { this.handler = handler; }
				
		protected abstract void Send(byte[] data);

    public void Binary()
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)0);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Error(string msg)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)1);
			writer.Write(msg);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Welcome(byte id, bool waitForGameState)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)3);
			writer.Write(id);
			writer.Write(waitForGameState);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Settings(bool twoSidedTable)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)4);
			writer.Write(twoSidedTable);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void PlayerSettings(byte playerId, bool invertedTable)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)5);
			writer.Write(playerId);
			writer.Write(invertedTable);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void NewPlayer(byte id, string nick, ulong pkey)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)6);
			writer.Write(id);
			writer.Write(nick);
			writer.Write(pkey);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Leave(byte player)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)7);
			writer.Write(player);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Nick(byte player, string nick)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)9);
			writer.Write(player);
			writer.Write(nick);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Start()
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)10);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Reset(byte player)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)12);
			writer.Write(player);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void NextTurn(byte nextPlayer)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)13);
			writer.Write(nextPlayer);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void StopTurn(byte player)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)15);
			writer.Write(player);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Chat(byte player, string text)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)17);
			writer.Write(player);
			writer.Write(text);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Print(byte player, string text)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)19);
			writer.Write(player);
			writer.Write(text);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Random(byte player, int id, int min, int max)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)21);
			writer.Write(player);
			writer.Write(id);
			writer.Write(min);
			writer.Write(max);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void RandomAnswer1(byte player, int id, ulong value)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)23);
			writer.Write(player);
			writer.Write(id);
			writer.Write(value);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void RandomAnswer2(byte player, int id, ulong value)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)25);
			writer.Write(player);
			writer.Write(id);
			writer.Write(value);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Counter(byte player, int counter, int value)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)27);
			writer.Write(player);
			writer.Write(counter);
			writer.Write(value);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void LoadDeck(int[] id, ulong[] type, int[] group)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)28);
			writer.Write((short)id.Length);
			foreach (int p in id)
				writer.Write(p);
			writer.Write((short)type.Length);
						foreach (ulong p in type)
							writer.Write(p);
			writer.Write((short)group.Length);
			foreach (int p in group)
				writer.Write(p);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void CreateCard(int[] id, ulong[] type, int group)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)29);
			writer.Write((short)id.Length);
			foreach (int p in id)
				writer.Write(p);
			writer.Write((short)type.Length);
						foreach (ulong p in type)
							writer.Write(p);
			writer.Write(group);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void CreateCardAt(int[] id, ulong[] key, Guid[] modelId, int[] x, int[] y, bool faceUp, bool persist)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)30);
			writer.Write((short)id.Length);
			foreach (int p in id)
				writer.Write(p);
			writer.Write((short)key.Length);
						foreach (ulong p in key)
							writer.Write(p);
			writer.Write((short)modelId.Length);
			foreach (Guid g in modelId)
				writer.Write(g.ToByteArray());
			writer.Write((short)x.Length);
			foreach (int p in x)
				writer.Write(p);
			writer.Write((short)y.Length);
			foreach (int p in y)
				writer.Write(p);
			writer.Write(faceUp);
			writer.Write(persist);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void CreateAliasDeprecated(int[] id, ulong[] type)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)31);
			writer.Write((short)id.Length);
			foreach (int p in id)
				writer.Write(p);
			writer.Write((short)type.Length);
						foreach (ulong p in type)
							writer.Write(p);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void MoveCard(byte player, int card, int group, int idx, bool faceUp, bool isScriptMove)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)33);
			writer.Write(player);
			writer.Write(card);
			writer.Write(group);
			writer.Write(idx);
			writer.Write(faceUp);
			writer.Write(isScriptMove);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void MoveCardAt(byte player, int card, int x, int y, int idx, bool faceUp, bool isScriptMove)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)35);
			writer.Write(player);
			writer.Write(card);
			writer.Write(x);
			writer.Write(y);
			writer.Write(idx);
			writer.Write(faceUp);
			writer.Write(isScriptMove);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Reveal(int card, ulong revealed, Guid guid)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)36);
			writer.Write(card);
			writer.Write(revealed);
			writer.Write(guid.ToByteArray());
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void RevealTo(byte[] players, int card, ulong[] encrypted)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)38);
			writer.Write((short)players.Length);
			foreach (byte p in players)
				writer.Write(p);
			writer.Write(card);
			writer.Write((short)encrypted.Length);
						foreach (ulong p in encrypted)
							writer.Write(p);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Peek(byte player, int card)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)40);
			writer.Write(player);
			writer.Write(card);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Untarget(byte player, int card)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)42);
			writer.Write(player);
			writer.Write(card);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Target(byte player, int card)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)44);
			writer.Write(player);
			writer.Write(card);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void TargetArrow(byte player, int card, int otherCard)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)46);
			writer.Write(player);
			writer.Write(card);
			writer.Write(otherCard);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Highlight(int card, string color)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)47);
			writer.Write(card);
			writer.Write(color);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Turn(byte player, int card, bool up)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)49);
			writer.Write(player);
			writer.Write(card);
			writer.Write(up);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Rotate(byte player, int card, CardOrientation rot)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)51);
			writer.Write(player);
			writer.Write(card);
			writer.Write((byte)rot);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void ShuffleDeprecated(int group, int[] card)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)52);
			writer.Write(group);
			writer.Write((short)card.Length);
			foreach (int p in card)
				writer.Write(p);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Shuffled(int group, int[] card, short[] pos)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)53);
			writer.Write(group);
			writer.Write((short)card.Length);
			foreach (int p in card)
				writer.Write(p);
			writer.Write((short)pos.Length);
			foreach (short p in pos)
				writer.Write(p);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void UnaliasGrpDeprecated(int group)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)54);
			writer.Write(group);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void UnaliasDeprecated(int[] card, ulong[] type)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)55);
			writer.Write((short)card.Length);
			foreach (int p in card)
				writer.Write(p);
			writer.Write((short)type.Length);
						foreach (ulong p in type)
							writer.Write(p);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void AddMarker(byte player, int card, Guid id, string name, ushort count)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)57);
			writer.Write(player);
			writer.Write(card);
			writer.Write(id.ToByteArray());
			writer.Write(name);
			writer.Write(count);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void RemoveMarker(byte player, int card, Guid id, string name, ushort count)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)59);
			writer.Write(player);
			writer.Write(card);
			writer.Write(id.ToByteArray());
			writer.Write(name);
			writer.Write(count);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void SetMarker(byte player, int card, Guid id, string name, ushort count)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)61);
			writer.Write(player);
			writer.Write(card);
			writer.Write(id.ToByteArray());
			writer.Write(name);
			writer.Write(count);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void TransferMarker(byte player, int from, int to, Guid id, string name, ushort count)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)63);
			writer.Write(player);
			writer.Write(from);
			writer.Write(to);
			writer.Write(id.ToByteArray());
			writer.Write(name);
			writer.Write(count);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void PassTo(byte player, int id, byte to, bool requested)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)65);
			writer.Write(player);
			writer.Write(id);
			writer.Write(to);
			writer.Write(requested);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void TakeFrom(int id, byte to)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)67);
			writer.Write(id);
			writer.Write(to);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void DontTake(int id)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)69);
			writer.Write(id);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void FreezeCardsVisibility(int group)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)70);
			writer.Write(group);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void GroupVis(byte player, int group, bool defined, bool visible)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)72);
			writer.Write(player);
			writer.Write(group);
			writer.Write(defined);
			writer.Write(visible);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void GroupVisAdd(byte player, int group, byte who)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)74);
			writer.Write(player);
			writer.Write(group);
			writer.Write(who);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void GroupVisRemove(byte player, int group, byte who)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)76);
			writer.Write(player);
			writer.Write(group);
			writer.Write(who);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void LookAt(byte player, int uid, int group, bool look)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)78);
			writer.Write(player);
			writer.Write(uid);
			writer.Write(group);
			writer.Write(look);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void LookAtTop(byte player, int uid, int group, int count, bool look)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)80);
			writer.Write(player);
			writer.Write(uid);
			writer.Write(group);
			writer.Write(count);
			writer.Write(look);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void LookAtBottom(byte player, int uid, int group, int count, bool look)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)82);
			writer.Write(player);
			writer.Write(uid);
			writer.Write(group);
			writer.Write(count);
			writer.Write(look);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void StartLimited(byte player, Guid[] packs)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)84);
			writer.Write(player);
			writer.Write((short)packs.Length);
			foreach (Guid g in packs)
				writer.Write(g.ToByteArray());
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void CancelLimited(byte player)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)86);
			writer.Write(player);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void CardSwitchTo(byte player, int card, string alternate)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)87);
			writer.Write(player);
			writer.Write(card);
			writer.Write(alternate);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void PlayerSetGlobalVariable(byte player, string name, string val)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)88);
			writer.Write(player);
			writer.Write(name);
			writer.Write(val);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void SetGlobalVariable(string name, string val)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)89);
			writer.Write(name);
			writer.Write(val);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Ping()
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)91);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void IsTableBackgroundFlipped(bool isFlipped)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)92);
			writer.Write(isFlipped);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void PlaySound(byte player, string name)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)93);
			writer.Write(player);
			writer.Write(name);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Ready(byte player)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)94);
			writer.Write(player);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void PlayerState(byte player, byte state)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)95);
			writer.Write(player);
			writer.Write(state);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void RemoteCall(byte player, string function, string args)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)96);
			writer.Write(player);
			writer.Write(function);
			writer.Write(args);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void GameStateReq(byte player)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)97);
			writer.Write(player);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void GameState(byte toPlayer, int[] cardIds, ulong[] cardTypes, int[] cardGroups, short[] cardGroupIdx)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)98);
			writer.Write(toPlayer);
			writer.Write((short)cardIds.Length);
			foreach (int p in cardIds)
				writer.Write(p);
			writer.Write((short)cardTypes.Length);
						foreach (ulong p in cardTypes)
							writer.Write(p);
			writer.Write((short)cardGroups.Length);
			foreach (int p in cardGroups)
				writer.Write(p);
			writer.Write((short)cardGroupIdx.Length);
			foreach (short p in cardGroupIdx)
				writer.Write(p);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void DeleteCard(int card, byte player)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)99);
			writer.Write(card);
			writer.Write(player);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}
	}
	
	class BinarySenderStub : BaseBinaryStub
	{
		private TcpClient to;
		
		public BinarySenderStub(TcpClient to, Handler handler) : base(handler)
		{ this.to = to; }
		
		protected override void Send(byte[] data)
		{
			try
			{
				Stream stream = to.GetStream();
				stream.Write(data, 0, data.Length); stream.Flush();
			}
			catch 
			{ 
// TODO: Notify disconnection
//				if (Program.Server != null && Program.Server.Disconnected(to))
//					return;
//				Program.Client.Disconnected();
			}
		}
	}
}
