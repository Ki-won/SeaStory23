using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaStory 
{
    public class ClientWrapper
    {
        private static Lazy<Task<ClientWrapper>> _instance =
                    new Lazy<Task<ClientWrapper>>(() => CreateAsync(), true);

        private WebSocketClient webSocketClient;

        // Fields to store user_id and seat_num
        private string _lastUserId;
        private int _lastSeatNum;

        public event Action LogoutCommandReceived;

        private ClientWrapper()
        {
            webSocketClient = new WebSocketClient("ws://218.150.181.67:8765");
            // webSocketClient = new WebSocketClient("ws://localhost:8765");
            webSocketClient.MessageReceived += WebSocketClient_MessageReceived;
        }

        public static Task<ClientWrapper> Instance => _instance.Value;

        public static async Task<ClientWrapper> CreateAsync()
        {
            var wrapper = new ClientWrapper();
            await wrapper.webSocketClient.ConnectAsync();
            return wrapper;
        }

        public async Task CloseAsync()
        {
            await webSocketClient.CloseAsync();
        }
        
        public async Task AddTimeAync(string user_id, int seat_num, int subscription_time)
        {
            if (!webSocketClient.IsConnected())
            {
                Console.WriteLine("WebSocket connection is not active.");
                return; // Exit the method if not connected
            }

            var message = new
            {
                command = "add_time",
                user_id = user_id,
                seat_num = seat_num,
                subscription_time = subscription_time
            };
            string jsonMessage = JsonSerializer.Serialize(message);
            await webSocketClient.SendAsync(jsonMessage);

        }


        public async Task ReserveUserAsync(string user_id, int seat_num)
        {
            if (!webSocketClient.IsConnected())
            {
                Console.WriteLine("WebSocket connection is not active.");
                return; // Exit the method if not connected
            }

            _lastUserId = user_id;
            _lastSeatNum = seat_num;

            var message = new
            {
                command = "reserve",
                user_id = user_id,
                seat_num = seat_num
            };
            string jsonMessage = JsonSerializer.Serialize(message);
            await webSocketClient.SendAsync(jsonMessage);
        }

        public async Task ActivateUserAsync(string user_id, int seat_num)
        {
            if (!webSocketClient.IsConnected())
            {
                Console.WriteLine("WebSocket connection is not active.");
                return; // Exit the method if not connected
            }

            _lastUserId = user_id;
            _lastSeatNum = seat_num;

            var message = new
            {
                command = "add",
                user_id = user_id,
                seat_num = seat_num
            };

            string jsonMessage = JsonSerializer.Serialize(message);
            await webSocketClient.SendAsync(jsonMessage);
        }

        public async Task DeactivateUserAsync()
        {
            if (!webSocketClient.IsConnected())
            {
                Console.WriteLine("WebSocket connection is not active.");
                return; // Exit the method if not connected
            }

            var message = new
            {
                command = "delete",
                user_id = _lastUserId,
                seat_num = _lastSeatNum
            };

            string jsonMessage = JsonSerializer.Serialize(message);
            await webSocketClient.SendAsync(jsonMessage);
        }

        public async Task ForceDeactivateUserAsync(string user_id, int seat_num)
        {
            if (!webSocketClient.IsConnected())
            {
                Console.WriteLine("WebSocket connection is not active.");
                return; // Exit the method if not connected
            }

            var message = new
            {
                command = "force_delete",
                user_id = user_id,
                seat_num = seat_num
            };

            string jsonMessage = JsonSerializer.Serialize(message);
            await webSocketClient.SendAsync(jsonMessage);
        }

        private void WebSocketClient_MessageReceived(string message)
        {
            try
            {
                using (JsonDocument document = JsonDocument.Parse(message))
                {
                    JsonElement root = document.RootElement;

                    // Check for "logout" command
                    if (root.TryGetProperty("command", out JsonElement commandElement))
                    {
                        if (commandElement.GetString() == "logout")
                        {
                            // Raise the event
                            LogoutCommandReceived?.Invoke();
                        }
                        else if (commandElement.GetString() == "force_logout")
                        {
                            MessageBox.Show("관리자에 의해 강제종료 되었습니다.");
                            // Raise the event
                            LogoutCommandReceived?.Invoke();
                        }
                        
                    }
                }
            }
            catch (JsonException e)
            {
                Console.WriteLine($"Invalid JSON received: {e.Message}");
                // Handle JSON parsing error
            }
        }

        public void ClearLogoutCommandReceived()
        {
            LogoutCommandReceived = null;
        }

    }
}
