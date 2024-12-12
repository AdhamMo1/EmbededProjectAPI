using MQTTnet.Client;
using MQTTnet;
using System.Text;

namespace EmbededTask.MQTT_Subscriber
{
    public static class Subscriber
    {
        public static string TagId;
        public static async Task SubscribeAsync()
        {
            // إعدادات MQTT
            string mqttServer = "7aa36ad03e2c42968adf3e501f78a0fb.s1.eu.hivemq.cloud"; // خادم HiveMQ
            int mqttPort = 8883; // المنفذ المشفر
            string mqttUser = "eslam_osama"; // اسم المستخدم
            string mqttPassword = "Eslam_task123"; // كلمة المرور
            string attendanceTopic = "school/attendance/project_O_K"; // موضوع الحضور

            // إنشاء خيارات العميل
            var options = new MqttClientOptionsBuilder()
                .WithTcpServer(mqttServer, mqttPort) // إعداد الخادم والمنفذ
                .WithCredentials(mqttUser, mqttPassword) // اسم المستخدم وكلمة المرور
                .WithTls() // تمكين TLS للاتصال المشفر
                .Build();

            // إنشاء عميل MQTT
            IMqttClient mqttClient = new MqttFactory().CreateMqttClient();


            // حدث الاتصال بالخادم
            mqttClient.ConnectedAsync += async e =>
            {
                try
                {
                    await mqttClient.SubscribeAsync(new MqttClientSubscribeOptionsBuilder()
                        .WithTopicFilter(attendanceTopic)
                        .Build());
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            };

            // معالجة الرسائل الواردة
            mqttClient.ApplicationMessageReceivedAsync += async e =>
            {
                string payload = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                TagId = payload;
            };


            // الاتصال بالخادم
            await mqttClient.ConnectAsync(options);

        }
    }
}
