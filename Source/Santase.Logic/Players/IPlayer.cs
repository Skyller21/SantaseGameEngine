﻿namespace Santase.Logic.Players
{
    using Santase.Logic.Cards;
    using Santase.Logic.PlayerActionValidate;

    public interface IPlayer
    {
        void AddCard(Card card);

        PlayerAction GetTurn(PlayerTurnContext context, IPlayerActionValidater actionValidator);

        void EndTurn(PlayerTurnContext context);
    }
}
