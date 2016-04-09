﻿using Sodium;

namespace ClashRoyaleProxy
{
    public class ClientState : State
    {
        public ServerState serverState;

        public KeyPair clientKey;
        public byte[] serverKey, nonce;
    }
}
