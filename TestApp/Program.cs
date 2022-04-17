using Confluent.Kafka;

var config = new ProducerConfig
{
    BootstrapServers = "localhost:9092",
    CompressionType = CompressionType.Gzip
};

using var producer = new ProducerBuilder<string, string>(config).Build();

await producer.ProduceAsync("test", new Message<string, string>
{
    Key = "test",
    Value = "value"
});