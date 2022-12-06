using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CardGameFrontEndConsole.Models;

namespace CardGameFrontEndConsole.Services
{
    public class CardGameHttpService : BaseHttpService, ICardGameHttpService
    {
        readonly Uri _baseUri;
        readonly IDictionary<string, string> _headers;

        public CardGameHttpService(Uri baseUri)
        {
            _baseUri = baseUri;
            _headers = new Dictionary<string, string>();
        }

        public async Task<GameStatus> StartGame(string gameType)
        {
            var url = new Uri(_baseUri, $"/api/cardgame/startgame?gametype={gameType}");
            var response = await SendRequestAsync<GameStatus>(url, HttpMethod.Get, _headers);

            return response;
        }

        public async Task<GameStatus> EndGame()
        {
            var url = new Uri(_baseUri, $"/api/cardgame/endgame");
            var response = await SendRequestAsync<GameStatus>(url, HttpMethod.Get, _headers);

            return response;
        }

        public async Task<PlayingCard> DealCard()
        {
            var url = new Uri(_baseUri, $"api/cardgame/dealcard");

            var card = await SendRequestAsync<PlayingCard>(url, HttpMethod.Get, _headers);

            return card;
        }

        public async Task<IEnumerable<PlayingCard>> DealCards(int nrOfCards)
        {
            var url = new Uri(_baseUri, $"api/cardgame/dealcards/?nrOfCards={nrOfCards}");

            var cards = await SendRequestAsync<IEnumerable<PlayingCard>>(url, HttpMethod.Get, _headers);

            return cards;
        }

        public async Task<IEnumerable<PlayingCard>> WinningCards(IEnumerable<PlayingCard> hand)
        {
            var url = new Uri(_baseUri, "api/cardgame/winningcards");
            var response = await SendRequestAsync<IEnumerable<PlayingCard>>(url, HttpMethod.Post, _headers, hand);

            return response;
        }
    }
}
