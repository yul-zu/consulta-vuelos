using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;



    public class Vuelo
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [BsonElement("pais_origen")]
        public string PaisOrigen { get; set; }

        [BsonElement("ciudad_origen")]
        public string CiudadOrigen { get; set; }

        [BsonElement("aeropuerto_origen")]
        public string AeropuertoOrigen { get; set; }

        [BsonElement("pais_destino")]
        public string PaisDestino { get; set; }

        [BsonElement("ciudad_destino")]
        public string CiudadDestino { get; set; }

        [BsonElement("aeropuerto_destino")]
        public string AeropuertoDestino { get; set; }

        [BsonElement("tipo_avion")]
        public string TipoAvion { get; set; }

        [BsonElement("cupo_avion")]
        public int CupoAvion { get; set; }

        [BsonElement("pasajeros_actuales")]
        public int PasajerosActuales { get; set; }

        [BsonElement("fecha_hora_salida")]
        public DateTime FechaHoraSalida { get; set; }

        [BsonElement("fecha_hora_llegada_aproximada")]
        public DateTime FechaHoraLlegadaAproximada { get; set; }

        [BsonElement("nombre_piloto")]
        public string NombrePiloto { get; set; }

        [BsonElement("estatus_vuelo")]
        public string EstatusVuelo { get; set; }
    }
