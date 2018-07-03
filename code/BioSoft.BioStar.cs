using System;
using System.Collections;
using System.Net;
using BioSoft.BioStarSDK;
using System.Runtime.InteropServices;

namespace BioSoft
{

    public class UsuarioBioStar
    {
        private const int TEMPLATE_SIZE = 384;
        private const int FACETEMPLATE_SIZE = 2284;
        private const int BS_MAX_TEMPLATE_PER_USER = 10;
        private const int BS_MAX_FACE_PER_USER = 5;

        private int _ID;
        private int _Dedos;
        private byte[] _Dedo1Huella;
        private byte[] _Dedo2Huella;
        private int _Dedo1Checksum;
        private int _Dedo2Checksum;
        private bool _Cara;
        private byte[] _CaraHuella;
        private int _CaraChecksum;
        private string _TarjetaID;

        public UsuarioBioStar(int ID, int Dedos, bool Cara)
        {
            _ID = ID;
            _Dedos = Dedos;
            _Cara = Cara;
            if (Dedos > 0)
                _Dedo1Huella = new byte[TEMPLATE_SIZE * 2];
            if (Dedos > 1)
                _Dedo2Huella = new byte[TEMPLATE_SIZE * 2];
            if (Cara)
                _CaraHuella = new byte[FACETEMPLATE_SIZE * BS_MAX_FACE_PER_USER];
        }

        public int ID { get { return _ID; } set { _ID = value; } }
        public int Dedos { get { return _Dedos; } set { _Dedos = value; } }
        public byte[] Dedo1Huella { get { return _Dedo1Huella; } set { _Dedo1Huella = value; } }
        public byte[] Dedo2Huella { get { return _Dedo2Huella; } set { _Dedo2Huella = value; } }
        public int Dedo1Checksum { get { return _Dedo1Checksum; } set { _Dedo1Checksum = value; } }
        public int Dedo2Checksum { get { return _Dedo2Checksum; } set { _Dedo2Checksum = value; } }
        public bool Cara { get { return _Cara; } set { _Cara = value; } }
        public byte[] CaraHuella { get { return _CaraHuella; } set { _CaraHuella = value; } }
        public int CaraChecksum { get { return _CaraChecksum; } set { _CaraChecksum = value; } }
        public string TarjetaID { get { return _TarjetaID; } set { _TarjetaID = value; } }
    }

    public class LogBioStar
    {
        private int _UsuarioID;
        private int _TipoEvento;
        private int _EventoTNA;
        private string _LectorID;
        private DateTime _FechaHora;

        public LogBioStar(int UsuarioID, int TipoEvento, int EventoTNA, string LectorID, 
            DateTime FechaHora)
        {
            _UsuarioID = UsuarioID;
            _TipoEvento = TipoEvento;
            _EventoTNA = EventoTNA;
            _LectorID = LectorID;
            _FechaHora = FechaHora;
        }

        public string ObtenerDescripcionEvento()
        {
            switch (_TipoEvento)
            {
                case SDK.BE_EVENT_SCAN_SUCCESS:
                    return "Escaneo exitoso";

                case SDK.BE_EVENT_ENROLL_BAD_FINGER:
                    return "Dedo erróneo en inscripción";

                case SDK.BE_EVENT_ENROLL_SUCCESS:
                    return "Inscripción exitosa";

                case SDK.BE_EVENT_ENROLL_FAIL:
                    return "Inscripción fallida";

                case SDK.BE_EVENT_ENROLL_CANCELED:
                    return "Inscripción cancelada";

                case SDK.BE_EVENT_VERIFY_BAD_FINGER:
                    return "Verificación dedo erróneo";

                case SDK.BE_EVENT_VERIFY_SUCCESS:
                    return "Verificación exitosa";

                case SDK.BE_EVENT_VERIFY_FAIL:
                    return "Verificación fallida";

                case SDK.BE_EVENT_VERIFY_CANCELED:
                    return "Verificación cancelada";

                case SDK.BE_EVENT_VERIFY_NO_FINGER:
                    return "Verificación sin dedo";

                case SDK.BE_EVENT_IDENTIFY_BAD_FINGER:
                    return "Identificación dedo erróneo";

                case SDK.BE_EVENT_IDENTIFY_SUCCESS:
                    return "Identificación exitosa";

                case SDK.BE_EVENT_IDENTIFY_FAIL:
                    return "Identificación fallida";

                case SDK.BE_EVENT_IDENTIFY_CANCELED:
                    return "Identificación cancelada";

                case SDK.BE_EVENT_IDENTIFY_FINGER:
                    return "Identificación exitosa (sólo dedo)";

                case SDK.BE_EVENT_IDENTIFY_FINGER_PIN:
                    return "Identificación exitosa (dedo y PIN)";

                case SDK.BE_EVENT_DELETE_BAD_FINGER:
                    return "Eliminación dedo erróneo";

                case SDK.BE_EVENT_DELETE_SUCCESS:
                    return "Eliminación exitosa";

                case SDK.BE_EVENT_DELETE_FAIL:
                    return "Eliminación fallida";

                case SDK.BE_EVENT_DELETE_ALL_SUCCESS:
                    return "Eliminación total exitosa";

                case SDK.BE_EVENT_VERIFY_DURESS:
                    return "Verificación coacción";

                case SDK.BE_EVENT_IDENTIFY_DURESS:
                    return "Identificación coacción";

                case SDK.BE_EVENT_TAMPER_SWITCH_ON:
                    return "Tamper encendido";

                case SDK.BE_EVENT_TAMPER_SWITCH_OFF:
                    return "Tamper apagado";

                case SDK.BE_EVENT_SYS_STARTED:
                    return "Sistema iniciado";

                case SDK.BE_EVENT_IDENTIFY_NOT_GRANTED:
                    return "Identificación no permitida";

                case SDK.BE_EVENT_VERIFY_NOT_GRANTED:
                    return "Verificación no permitida";

                case SDK.BE_EVENT_IDENTIFY_LIMIT_COUNT:
                    return "Identificación en límite";

                case SDK.BE_EVENT_IDENTIFY_LIMIT_TIME:
                    return "Identificación límite de tiempo";

                case SDK.BE_EVENT_IDENTIFY_DISABLED:
                    return "Identificación desactivada";

                case SDK.BE_EVENT_IDENTIFY_EXPIRED:
                    return "Identificación expirada";

                case SDK.BE_EVENT_APB_FAIL:
                    return "Anti-passback fallada";

                case SDK.BE_EVENT_COUNT_LIMIT:
                    return "Límite de entradas";

                case SDK.BE_EVENT_TIME_INTERVAL_LIMIT:
                    return "Límite de intervalo de entradas";

                case SDK.BE_EVENT_INVALID_AUTH_MODE:
                    return "Modo de autenticación inválido";

                case SDK.BE_EVENT_EXPIRED_USER:
                    return "El usuario expiró";

                case SDK.BE_EVENT_NOT_GRANTED:
                    return "Acceso no autorizado";

                case SDK.BE_EVENT_DOOR0_OPEN:
                    return "Puerta 0 abierta";

                case SDK.BE_EVENT_DOOR0_CLOSED:
                    return "Puerta 0 cerrada";

                case SDK.BE_EVENT_DOOR1_OPEN:
                    return "Puerta 1 abierta";

                case SDK.BE_EVENT_DOOR1_CLOSED:
                    return "Puerta 1 cerrada";

                case SDK.BE_EVENT_DOOR0_FORCED_OPEN:
                    return "Puerta 0 forzada abierta";

                case SDK.BE_EVENT_DOOR1_FORCED_OPEN:
                    return "Puerta 1 forzada abierta";

                case SDK.BE_EVENT_DOOR0_HELD_OPEN:
                    return "Puerta 0 sostenida abierta";

                case SDK.BE_EVENT_DOOR1_HELD_OPEN:
                    return "Puerta 1 sostenida abierta";

                case SDK.BE_EVENT_DOOR0_RELAY_ON:
                    return "Puerta 0 Relay encendido";

                case SDK.BE_EVENT_DOOR1_RELAY_ON:
                    return "Puerta 1 Relay encendido";

                case SDK.BE_EVENT_TIMEOUT:
                    return "Tiempo agotado";

                // IO event
                case SDK.BE_EVENT_INTERNAL_INPUT0:
                    return "Detectado interna entrada 0";

                case SDK.BE_EVENT_INTERNAL_INPUT1:
                    return "Detectado interna entrada 1";

                case SDK.BE_EVENT_SECONDARY_INPUT0:
                    return "Detectado Secondary entrada 0";

                case SDK.BE_EVENT_SECONDARY_INPUT1:
                    return "Detectado Secondary entrada 1";

                case SDK.BE_EVENT_SIO0_INPUT0:
                    return "Detectado SIO 0 entrada 0";

                case SDK.BE_EVENT_SIO0_INPUT1:
                    return "Detectado SIO 0 entrada 1";

                case SDK.BE_EVENT_SIO0_INPUT2:
                    return "Detectado SIO 0 entrada 2";

                case SDK.BE_EVENT_SIO0_INPUT3:
                    return "Detectado SIO 0 entrada 3";

                case SDK.BE_EVENT_SIO1_INPUT0:
                    return "Detectado SIO 1 entrada 0";

                case SDK.BE_EVENT_SIO1_INPUT1:
                    return "Detectado SIO 1 entrada 1";

                case SDK.BE_EVENT_SIO1_INPUT2:
                    return "Detectado SIO 1 entrada 2";

                case SDK.BE_EVENT_SIO1_INPUT3:
                    return "Detectado SIO 1 entrada 3";

                case SDK.BE_EVENT_SIO2_INPUT0:
                    return "Detectado SIO 2 entrada 0";

                case SDK.BE_EVENT_SIO2_INPUT1:
                    return "Detectado SIO 2 entrada 1";

                case SDK.BE_EVENT_SIO2_INPUT2:
                    return "Detectado SIO 2 entrada 2";

                case SDK.BE_EVENT_SIO2_INPUT3:
                    return "Detectado SIO 2 entrada 3";

                case SDK.BE_EVENT_SIO3_INPUT0:
                    return "Detectado SIO 3 entrada 0";

                case SDK.BE_EVENT_SIO3_INPUT1:
                    return "Detectado SIO 3 entrada 1";

                case SDK.BE_EVENT_SIO3_INPUT2:
                    return "Detectado SIO 3 entrada 2";

                case SDK.BE_EVENT_SIO3_INPUT3:
                    return "Detectado SIO 3 entrada 3";

                case SDK.BE_EVENT_LOCKED:
                    return "Bloqueado";

                case SDK.BE_EVENT_UNLOCKED:
                    return "Desbloqueado";

                case SDK.BE_EVENT_TIME_SET:
                    return "Hora establecida";

                case SDK.BE_EVENT_SOCK_CONN:
                    return "Conectado";

                case SDK.BE_EVENT_SOCK_DISCONN:
                    return "Desconectado";

                case SDK.BE_EVENT_SERVER_SOCK_CONN:
                    return "Servidor conectado";

                case SDK.BE_EVENT_SERVER_SOCK_DISCONN:
                    return "Servidor desconectado";

                case SDK.BE_EVENT_LINK_CONN:
                    return "Link conectado";

                case SDK.BE_EVENT_LINK_DISCONN:
                    return "Link desconectado";

                case SDK.BE_EVENT_INIT_IP:
                    return "IP Inicializado";

                case SDK.BE_EVENT_INIT_DHCP:
                    return "DHCP Inicializado";

                case SDK.BE_EVENT_DHCP_SUCCESS:
                    return "DHCP exitoso";


                default:
                    return _TipoEvento.ToString();
            }
        }

        public string ObtenerDescripcionTNA()
        {
            switch (_EventoTNA)
            {
                case 0:
                    return "Entrada";

                case 1:
                    return "Salida";

                default:
                    return "";
            }
        }

        public int UsuarioID { get { return _UsuarioID; } set { _UsuarioID = value; } }
        public int TipoEvento { get { return _TipoEvento; } set { _TipoEvento = value; } }
        public int EventoTNA { get { return _EventoTNA; } set { _EventoTNA = value; } }
        public string LectorID { get { return _LectorID; } set { _LectorID = value; } }
        public DateTime FechaHora { get { return _FechaHora; } set { _FechaHora = value; } }
    }

    public class DispositivoBioStar
    {
        private const int TEMPLATE_SIZE = 384;
        private const int FACETEMPLATE_SIZE = 2284;
        private const int BS_MAX_TEMPLATE_PER_USER = 10;
        private const int BS_MAX_FACE_PER_USER = 5;
        public const int BS_MAX_IMAGE_SIZE = (64 * 1024);
        public const int BS_MAX_LOG_ENTRIES = 8192;

        private int _Direccion;
        private string _IP;
        private int _ID;
        private int _HandleConexion;
        private int _Tipo;
        private string _Descripcion;
        private bool _Conectado;
        private ArrayList _Usuarios;
        private ArrayList _Log;
        private BioStar _BioStar;

        private SDK.BEConfigData m_ConfigBEPlus;
        private SDK.BEConfigDataBLN m_ConfigBLN;
        private SDK.BSIPConfig m_ConfigBST;

        public DispositivoBioStar(BioStar BioStar, int Direccion, string IP, int ID, 
            int Tipo, string Descripcion)
        {
            _BioStar = BioStar;
            _Direccion = Direccion;
            _IP = IP;
            _ID = ID;
            _Tipo = Tipo;
            _Descripcion = Descripcion;
            _Usuarios = new ArrayList();
            _Log = new ArrayList();
        }

        // Obtener el puerto de un dispositivo de la lista
        public int ObtenerPuerto(ref int Puerto)
        {
            int configSize = 0;
            if (Tipo == SDK.BS_DEVICE_BEPLUS || Tipo == SDK.BS_DEVICE_XPASS)
            {
                IntPtr config = Marshal.AllocHGlobal(Marshal.SizeOf(m_ConfigBEPlus));
                int result = SDK.BS_ReadConfigUDP(_BioStar.HandleUDP, (uint)Direccion, (uint)ID, 
                    SDK.BEPLUS_CONFIG, ref configSize, config);
                if (result != SDK.BS_SUCCESS)
                {
                    Marshal.FreeHGlobal(config);
                    return result;
                }

                m_ConfigBEPlus = (SDK.BEConfigData)Marshal.PtrToStructure(config, typeof(SDK.BEConfigData));
                Marshal.FreeHGlobal(config);
                Puerto = m_ConfigBEPlus.port;
            }
            else if (Tipo == SDK.BS_DEVICE_BIOLITE)
            {
                IntPtr config = Marshal.AllocHGlobal(Marshal.SizeOf(m_ConfigBLN));
                int result = SDK.BS_ReadConfigUDP(_BioStar.HandleUDP, (uint)Direccion, (uint)ID, SDK.BLN_CONFIG, ref configSize, config);
                if (result != SDK.BS_SUCCESS)
                {
                    Marshal.FreeHGlobal(config);
                    return result;
                }

                m_ConfigBLN = (SDK.BEConfigDataBLN)Marshal.PtrToStructure(config, typeof(SDK.BEConfigDataBLN));
                Marshal.FreeHGlobal(config);
                Puerto = m_ConfigBLN.port;
            }
            else if (Tipo == SDK.BS_DEVICE_BIOSTATION)
            {
                IntPtr config = Marshal.AllocHGlobal(Marshal.SizeOf(m_ConfigBST));
                int result = SDK.BS_ReadConfigUDP(_BioStar.HandleUDP, (uint)Direccion, (uint)ID, SDK.BS_CONFIG_TCPIP, ref configSize, config);
                if (result != SDK.BS_SUCCESS)
                {
                    Marshal.FreeHGlobal(config);
                    return result;
                }

                m_ConfigBST = (SDK.BSIPConfig)Marshal.PtrToStructure(config, typeof(SDK.BSIPConfig));
                Marshal.FreeHGlobal(config);
                if (m_ConfigBST.useServer)
                    Puerto = (int)m_ConfigBST.serverPort;
                else
                    Puerto = (int)m_ConfigBST.port;
            }
            else if (Tipo == SDK.BS_DEVICE_DSTATION)
            {
                IntPtr config = Marshal.AllocHGlobal(Marshal.SizeOf(m_ConfigBST));

                int result = SDK.BS_ReadConfigUDP(_BioStar.HandleUDP, (uint)Direccion, (uint)ID, SDK.BS_CONFIG_TCPIP, ref configSize, config);
                if (result != SDK.BS_SUCCESS)
                {
                    Marshal.FreeHGlobal(config);
                    return result;
                }

                m_ConfigBST = (SDK.BSIPConfig)Marshal.PtrToStructure(config, typeof(SDK.BSIPConfig));
                Marshal.FreeHGlobal(config);
                if (m_ConfigBST.useServer)
                    Puerto = (int)m_ConfigBST.serverPort;
                else
                    Puerto = (int)m_ConfigBST.port;
            }
            else if (Tipo == SDK.BS_DEVICE_XSTATION || Tipo == SDK.BS_DEVICE_BIOSTATION2)
            {
                IntPtr config = Marshal.AllocHGlobal(Marshal.SizeOf(m_ConfigBST));

                int result = SDK.BS_ReadConfigUDP(_BioStar.HandleUDP, (uint)Direccion, (uint)ID, SDK.BS_CONFIG_TCPIP, ref configSize, config);
                if (result != SDK.BS_SUCCESS)
                {
                    Marshal.FreeHGlobal(config);
                    return result;
                }

                m_ConfigBST = (SDK.BSIPConfig)Marshal.PtrToStructure(config, typeof(SDK.BSIPConfig));
                Marshal.FreeHGlobal(config);

                if (m_ConfigBST.useServer)
                    Puerto = (int)m_ConfigBST.serverPort;
                else
                    Puerto = (int)m_ConfigBST.port;
            }
            return 0;
        }

        // Conectar al dispositivo
        public int Conectar()
        {
            IPAddress addr = new IPAddress(Direccion);
            int handle = 0;
            int Puerto = 0;
            ObtenerPuerto(ref Puerto);
            int result = SDK.BS_OpenSocket(addr.ToString(), Puerto, ref handle);
            if (result == SDK.BS_SUCCESS)
                HandleConexion = handle;
            return result;
        }

        // Leer una tarjeta magnética del dispositivo
        private int LeerTarjeta(ref string ID, ref int IDPersonal)
        {
            uint card_id = 0;
            int custom_id = 0;
            int result = SDK.BS_ReadCardIDEx(HandleConexion, ref card_id, ref custom_id);
            if (result != SDK.BS_SUCCESS)
                return result;

            ID = card_id.ToString("X");
            IDPersonal = custom_id;
            return 0;
        }

        // Obtener los usuarios del dispositivo
        public int LeerUsuarios()
        {
            _Usuarios.Clear();

            int result = 0;
            UsuarioBioStar Usuario;
            int m_NumOfUser = 0;
            int m_NumOfTemplate = 0;
            switch (Tipo)
            {
                case SDK.BS_DEVICE_BEPLUS:
                case SDK.BS_DEVICE_BIOLITE:
                case SDK.BS_DEVICE_XPASS:
                    {
                        result = SDK.BS_GetUserDBInfo(HandleConexion, ref m_NumOfUser, ref m_NumOfTemplate);
                        if (result != SDK.BS_SUCCESS)
                            return result;

                        SDK.BEUserHdr[] userHdr = new SDK.BEUserHdr[m_NumOfUser];
                        IntPtr userInfo = Marshal.AllocHGlobal(m_NumOfUser * Marshal.SizeOf(typeof(SDK.BEUserHdr)));

                        result = SDK.BS_GetAllUserInfoBEPlus(HandleConexion, userInfo, ref m_NumOfUser);

                        if (result != SDK.BS_SUCCESS && result != SDK.BS_ERR_NOT_FOUND)
                        {
                            Marshal.FreeHGlobal(userInfo);
                            return result;
                        }

                        for (int i = 0; i < m_NumOfUser; i++)
                        {
                            userHdr[i] = (SDK.BEUserHdr)Marshal.PtrToStructure(new IntPtr(userInfo.ToInt32() + i * Marshal.SizeOf(typeof(SDK.BEUserHdr))), typeof(SDK.BEUserHdr));
                            Usuario = new UsuarioBioStar((int)userHdr[i].userID, userHdr[i].numOfFinger, false);
                            Usuario.TarjetaID = userHdr[i].cardID.ToString("X");
                            Usuario.Dedo1Checksum = userHdr[i].fingerChecksum[0];
                            if (userHdr[i].numOfFinger > 1)
                                Usuario.Dedo2Checksum = userHdr[i].fingerChecksum[1];
                            _Usuarios.Add(Usuario);
                        }

                        Marshal.FreeHGlobal(userInfo);
                    }
                    break;

                case SDK.BS_DEVICE_BIOSTATION:
                    {
                        result = SDK.BS_GetUserDBInfo(HandleConexion, ref m_NumOfUser, ref m_NumOfTemplate);
                        if (result != SDK.BS_SUCCESS)
                            return result;

                        SDK.BSUserHdrEx[] userHdr = new SDK.BSUserHdrEx[m_NumOfUser];

                        IntPtr userInfo = Marshal.AllocHGlobal(m_NumOfUser * Marshal.SizeOf(typeof(SDK.BSUserHdrEx)));

                        result = SDK.BS_GetAllUserInfoEx(HandleConexion, userInfo, ref m_NumOfUser);
                        if (result != SDK.BS_SUCCESS && result != SDK.BS_ERR_NOT_FOUND)
                        {
                            Marshal.FreeHGlobal(userInfo);
                            return result;
                        }

                        for (int i = 0; i < m_NumOfUser; i++)
                        {
                            userHdr[i] = (SDK.BSUserHdrEx)Marshal.PtrToStructure(new IntPtr(userInfo.ToInt32() + i * Marshal.SizeOf(typeof(SDK.BSUserHdrEx))), typeof(SDK.BSUserHdrEx));
                            Usuario = new UsuarioBioStar((int)userHdr[i].ID, userHdr[i].numOfFinger, false);
                            Usuario.TarjetaID = userHdr[i].cardID.ToString("X");
                            Usuario.Dedo1Checksum = userHdr[i].checksum[0];
                            if (userHdr[i].numOfFinger > 1)
                                Usuario.Dedo2Checksum = userHdr[i].checksum[1];
                            _Usuarios.Add(Usuario);
                        }
                        Marshal.FreeHGlobal(userInfo);
                    }
                    break;

                case SDK.BS_DEVICE_DSTATION:
                    {
                        result = SDK.BS_GetUserDBInfo(HandleConexion, ref m_NumOfUser, ref m_NumOfTemplate);
                        if (result != SDK.BS_SUCCESS)
                            return result;

                        result = SDK.BS_GetUserFaceInfo(HandleConexion, ref m_NumOfUser, ref m_NumOfTemplate);
                        if (result != SDK.BS_SUCCESS)
                            return result;

                        SDK.DSUserHdr[] userHdr = new SDK.DSUserHdr[m_NumOfUser];

                        IntPtr userInfo = Marshal.AllocHGlobal(m_NumOfUser * Marshal.SizeOf(typeof(SDK.DSUserHdr)));

                        result = SDK.BS_GetAllUserInfoDStation(HandleConexion, userInfo, ref m_NumOfUser);
                        if (result != SDK.BS_SUCCESS && result != SDK.BS_ERR_NOT_FOUND)
                        {
                            Marshal.FreeHGlobal(userInfo);
                            return result;
                        }

                        for (int i = 0; i < m_NumOfUser; i++)
                        {
                            userHdr[i] = (SDK.DSUserHdr)Marshal.PtrToStructure(new IntPtr(userInfo.ToInt32() + i * Marshal.SizeOf(typeof(SDK.DSUserHdr))), typeof(SDK.DSUserHdr));
                            Usuario = new UsuarioBioStar((int)userHdr[i].ID, userHdr[i].numOfFinger, userHdr[i].numOfFace > 0);
                            Usuario.TarjetaID = userHdr[i].cardID.ToString("X");
                            Usuario.Dedo1Checksum = (int)userHdr[i].fingerChecksum[0];
                            if (userHdr[i].numOfFinger > 1)
                                Usuario.Dedo2Checksum = (int)userHdr[i].fingerChecksum[1];
                            if (userHdr[i].numOfFace > 0)
                                Usuario.CaraChecksum = (int)userHdr[i].faceChecksum[1];
                            _Usuarios.Add(Usuario);
                        }

                        Marshal.FreeHGlobal(userInfo);
                    }
                    break;

                case SDK.BS_DEVICE_XSTATION:
                    {
                        result = SDK.BS_GetUserDBInfo(HandleConexion, ref m_NumOfUser, ref m_NumOfTemplate);
                        if (result != SDK.BS_SUCCESS)
                            return result;

                        SDK.XSUserHdr[] userHdr = new SDK.XSUserHdr[m_NumOfUser];

                        IntPtr userInfo = Marshal.AllocHGlobal(m_NumOfUser * Marshal.SizeOf(typeof(SDK.XSUserHdr)));

                        result = SDK.BS_GetAllUserInfoXStation(HandleConexion, userInfo, ref m_NumOfUser);
                        if (result != SDK.BS_SUCCESS && result != SDK.BS_ERR_NOT_FOUND)
                        {
                            Marshal.FreeHGlobal(userInfo);
                            return result;
                        }

                        for (int i = 0; i < m_NumOfUser; i++)
                        {
                            userHdr[i] = (SDK.XSUserHdr)Marshal.PtrToStructure(new IntPtr(userInfo.ToInt32() + i * Marshal.SizeOf(typeof(SDK.XSUserHdr))), typeof(SDK.XSUserHdr));
                            Usuario = new UsuarioBioStar((int)userHdr[i].ID, userHdr[i].numOfFinger, userHdr[i].numOfFace > 0);
                            Usuario.TarjetaID = userHdr[i].cardID.ToString("X");
                            Usuario.Dedo1Checksum = (int)userHdr[i].fingerChecksum[0];
                            if (userHdr[i].numOfFinger > 1)
                                Usuario.Dedo2Checksum = (int)userHdr[i].fingerChecksum[1];
                            if (userHdr[i].numOfFace > 0)
                                Usuario.CaraChecksum = (int)userHdr[i].faceChecksum[1];
                            _Usuarios.Add(Usuario);
                        }
                        Marshal.FreeHGlobal(userInfo);
                    }
                    break;

                case SDK.BS_DEVICE_BIOSTATION2:
                    {
                        result = SDK.BS_GetUserDBInfo(HandleConexion, ref m_NumOfUser, ref m_NumOfTemplate);
                        if (result != SDK.BS_SUCCESS)
                            return result;

                        SDK.BS2UserHdr[] userHdr = new SDK.BS2UserHdr[m_NumOfUser];

                        IntPtr userInfo = Marshal.AllocHGlobal(m_NumOfUser * Marshal.SizeOf(typeof(SDK.BS2UserHdr)));

                        result = SDK.BS_GetAllUserInfoBioStation2(HandleConexion, userInfo, ref m_NumOfUser);
                        if (result != SDK.BS_SUCCESS && result != SDK.BS_ERR_NOT_FOUND)
                        {
                            Marshal.FreeHGlobal(userInfo);
                            return result;
                        }

                        for (int i = 0; i < m_NumOfUser; i++)
                        {
                            userHdr[i] = (SDK.BS2UserHdr)Marshal.PtrToStructure(new IntPtr(userInfo.ToInt32() + i * Marshal.SizeOf(typeof(SDK.BS2UserHdr))), typeof(SDK.BS2UserHdr));
                            Usuario = new UsuarioBioStar((int)userHdr[i].ID, userHdr[i].numOfFinger, userHdr[i].numOfFace > 0);
                            Usuario.TarjetaID = userHdr[i].cardID.ToString("X");
                            Usuario.Dedo1Checksum = (int)userHdr[i].fingerChecksum[0];
                            if (userHdr[i].numOfFinger > 1)
                                Usuario.Dedo2Checksum = (int)userHdr[i].fingerChecksum[1];
                            if (userHdr[i].numOfFace > 0)
                                Usuario.CaraChecksum = (int)userHdr[i].faceChecksum[1];
                            _Usuarios.Add(Usuario);
                        }

                        Marshal.FreeHGlobal(userInfo);
                    }
                    break;
            }
            return 0;
        }

        // Obtener un indice usuario basado en el ID
        public UsuarioBioStar UsuarioPorID(int ID)
        {
            for (int i = 0; i < _Usuarios.Count; i++)
                if (((UsuarioBioStar)_Usuarios[i]).ID == ID)
                    return (UsuarioBioStar)_Usuarios[i];
            return null;
        }
        
        public delegate void HuellaCallback(int ADedo, int AHuella);

        // Agregar un usuario en el dispositivo
        public int AgregarUsuario(int ID, string Nombre, int Dedos, bool Cara, int NivelAdmin,
            int NivelSeguridad, int TipoTarjeta, long FechaInicio, long FechaFin, bool Coaccion1,
            bool Coaccion2, int ModoAutenticacion, string GrupoAcceso, bool Tarjeta, HuellaCallback Funcion)
        {
            UsuarioBioStar Usuario = new UsuarioBioStar(ID, Dedos, Cara);
            int result = 0;
            ushort fingerChecksum1 = 0;
            ushort fingerChecksum2 = 0;
            int numOfFinger = 0;
            if (Dedos > 0)
            {
                switch (Tipo)
                {
                    case SDK.BS_DEVICE_BIOSTATION:
                    case SDK.BS_DEVICE_BEPLUS:
                    case SDK.BS_DEVICE_BIOLITE:
                    case SDK.BS_DEVICE_DSTATION:
                    case SDK.BS_DEVICE_BIOSTATION2:
                        {
                            byte[] templateData = new byte[TEMPLATE_SIZE * BS_MAX_TEMPLATE_PER_USER];
                            numOfFinger++;

                            // VER CALLBACK
                            Funcion(1, 1);
                            result = SDK.BS_ScanTemplate(HandleConexion, templateData);
                            if (result != SDK.BS_SUCCESS)
                                return result;

                            Buffer.BlockCopy(templateData, 0, Usuario.Dedo1Huella, 0, TEMPLATE_SIZE);

                            // VER CALLBACK
                            Funcion(1, 2);
                            result = SDK.BS_ScanTemplate(HandleConexion, templateData);
                            if (result != SDK.BS_SUCCESS)
                                return result;

                            Buffer.BlockCopy(templateData, 0, Usuario.Dedo1Huella, TEMPLATE_SIZE, TEMPLATE_SIZE);

                            for (int i = 0; i < TEMPLATE_SIZE; i++)
                                fingerChecksum1 += Usuario.Dedo1Huella[i];
                            Usuario.Dedo1Checksum = fingerChecksum1;


                            if (Dedos > 1)
                            {
                                numOfFinger++;

                                // VER CALLBACK
                                Funcion(2, 1);
                                result = SDK.BS_ScanTemplate(HandleConexion, templateData);
                                if (result != SDK.BS_SUCCESS)
                                    return result;

                                Buffer.BlockCopy(templateData, 0, Usuario.Dedo2Huella, 0, TEMPLATE_SIZE);

                                // VER CALLBACK
                                Funcion(2, 2);
                                result = SDK.BS_ScanTemplate(HandleConexion, templateData);
                                if (result != SDK.BS_SUCCESS)
                                    return result;

                                Buffer.BlockCopy(templateData, 0, Usuario.Dedo2Huella, TEMPLATE_SIZE, TEMPLATE_SIZE);

                                for (int i = 0; i < TEMPLATE_SIZE; i++)
                                    fingerChecksum2 += Usuario.Dedo2Huella[i];
                                Usuario.Dedo2Checksum = fingerChecksum2;
                            }
                        }
                        break;
                }
            }

            if (Cara)
            {
                switch (Tipo)
                {
                    case SDK.BS_DEVICE_DSTATION:
                        {
                            int imageLen = 0;
                            byte[] imageData = new byte[BS_MAX_IMAGE_SIZE];
                            byte[] faceTemplate = new byte[FACETEMPLATE_SIZE * BS_MAX_FACE_PER_USER];

                            result = SDK.BS_ReadFaceData(HandleConexion, ref imageLen, imageData, faceTemplate);
                            if (result != SDK.BS_SUCCESS)
                                return result;

                            Buffer.BlockCopy(faceTemplate, 0, Usuario.CaraHuella, 0, TEMPLATE_SIZE);
                            break;

                            System.Threading.Thread.Sleep(500);     // The delay is required that is more than five miliseconds.
                        }
                        break;
                }
            }


            switch (Tipo)
            {
                case SDK.BS_DEVICE_BEPLUS:
                case SDK.BS_DEVICE_BIOLITE:
                case SDK.BS_DEVICE_XPASS:
                    {
                        SDK.BEUserHdr userHdr = new SDK.BEUserHdr();
                        userHdr.fingerChecksum = new ushort[2];
                        userHdr.isDuress = new byte[2];
                        userHdr.numOfFinger = (ushort)numOfFinger;

                        userHdr.fingerChecksum[0] = (ushort)fingerChecksum1;
                        userHdr.fingerChecksum[1] = (ushort)fingerChecksum2;

                        userHdr.password = new byte[17];
                        byte[] tmppw = System.Text.Encoding.Default.GetBytes("1234");
                        Buffer.BlockCopy(tmppw, 0, userHdr.password, 0, 4);

                        userHdr.userID = (uint)ID;

                        userHdr.adminLevel = (ushort)NivelAdmin;
                        userHdr.securityLevel = (ushort)NivelSeguridad;
                        userHdr.cardFlag = (byte)TipoTarjeta;
                        userHdr.startTime = (int)((FechaInicio - new DateTime(1970, 1, 1).Ticks) / 10000000);
                        userHdr.expiryTime = (int)((FechaFin - new DateTime(1970, 1, 1).Ticks) / 10000000);
                        userHdr.isDuress[0] = (Coaccion1) ? (byte)1 : (byte)0;
                        userHdr.isDuress[1] = (Coaccion2) ? (byte)1 : (byte)0;
                        userHdr.opMode = (ushort)ModoAutenticacion;

                        string TarjetaID = "0";
                        int TarjetaIDPersonal = 0;
                        if (Tarjeta)
                            LeerTarjeta(ref TarjetaID, ref TarjetaIDPersonal);

                        userHdr.cardID = UInt32.Parse(TarjetaID, System.Globalization.NumberStyles.HexNumber);
                        userHdr.cardCustomID = (byte)TarjetaIDPersonal;

                        userHdr.cardVersion = SDK.BE_CARD_VERSION_1;
                        userHdr.disabled = 0;
                        userHdr.dualMode = 0;
                        userHdr.accessGroupMask = UInt32.Parse(GrupoAcceso, System.Globalization.NumberStyles.HexNumber);

                        IntPtr userInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SDK.BEUserHdr)));
                        Marshal.StructureToPtr(userHdr, userInfo, true);

                        result = SDK.BS_EnrollUserBEPlus(HandleConexion, userInfo, Usuario.Dedo1Huella);
                        Marshal.FreeHGlobal(userInfo);
                        if (result != SDK.BS_SUCCESS)
                            return result;
                    }
                    break;

                case SDK.BS_DEVICE_BIOSTATION:
                    {
                        SDK.BSUserHdrEx userHdr = new SDK.BSUserHdrEx();

                        userHdr.checksum = new ushort[5];
                        userHdr.name = new byte[33];
                        userHdr.department = new byte[33];
                        userHdr.password = new byte[17];

                        userHdr.authLimitCount = 0;
                        userHdr.timedAntiPassback = 0;
                        userHdr.disabled = 0;

                        userHdr.numOfFinger = (ushort)numOfFinger;

                        userHdr.checksum[0] = (ushort)fingerChecksum1;
                        userHdr.checksum[1] = (ushort)fingerChecksum2;

                        userHdr.ID = (uint)ID;
                        userHdr.adminLevel = (ushort)((NivelAdmin == 1) ? SDK.BS_USER_ADMIN : SDK.BS_USER_NORMAL);
                        userHdr.securityLevel = (ushort)(NivelSeguridad + SDK.BS_USER_SECURITY_DEFAULT);

                        userHdr.bypassCard = (byte)TipoTarjeta;
                        userHdr.startDateTime = (uint)((FechaInicio - new DateTime(1970, 1, 1).Ticks) / 10000000);
                        userHdr.expireDateTime = (uint)((FechaFin - new DateTime(1970, 1, 1).Ticks) / 10000000);
                        userHdr.duressMask = 0;
                        if (Coaccion1)
                            userHdr.duressMask |= 0x01;
                        if (Coaccion2)
                            userHdr.duressMask |= 0x02;
                        if (ModoAutenticacion == 0)
                            userHdr.authMode = 0;
                        else
                            userHdr.authMode = (ushort)(ModoAutenticacion + SDK.BS_AUTH_FINGER_ONLY - 1);

                        string TarjetaID = "0";
                        int TarjetaIDPersonal = 0;
                        if (Tarjeta)
                            LeerTarjeta(ref TarjetaID, ref TarjetaIDPersonal);

                        userHdr.cardID = UInt32.Parse(TarjetaID, System.Globalization.NumberStyles.HexNumber);
                        userHdr.customID = (byte)TarjetaIDPersonal;
                        userHdr.version = SDK.BE_CARD_VERSION_1;

                        userHdr.accessGroupMask = UInt32.Parse(GrupoAcceso, System.Globalization.NumberStyles.HexNumber);

                        IntPtr userInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SDK.BSUserHdrEx)));
                        Marshal.StructureToPtr(userHdr, userInfo, true);

                        userHdr.name = System.Text.Encoding.ASCII.GetBytes(Nombre);

                        result = SDK.BS_EnrollUserEx(HandleConexion, userInfo, Usuario.Dedo1Huella);
                        Marshal.FreeHGlobal(userInfo);
                        if (result != SDK.BS_SUCCESS)
                            return result;
                    }
                    break;

                case SDK.BS_DEVICE_DSTATION:
                    {
                        SDK.DSUserHdr userHdr = new SDK.DSUserHdr();

                        userHdr.name = new ushort[48];
                        userHdr.department = new ushort[48];
                        userHdr.password = new ushort[16];
                        userHdr.duress = new byte[10];
                        userHdr.reserved = new byte[2];
                        userHdr.fingerType = new byte[10];
                        userHdr.reserved1 = new byte[2];
                        userHdr.fingerChecksum = new uint[10];
                        userHdr.faceChecksum = new uint[5];
                        userHdr.reserved2 = new uint[10];

                        userHdr.disabled = 0;
                        userHdr.numOfFinger = (ushort)numOfFinger;
                        userHdr.fingerChecksum[0] = (ushort)fingerChecksum1;
                        userHdr.fingerChecksum[1] = (ushort)fingerChecksum2;

                        userHdr.ID = (uint)ID;
                        userHdr.adminLevel = (ushort)((NivelAdmin == 1) ? SDK.BS_USER_ADMIN : SDK.BS_USER_NORMAL);
                        userHdr.securityLevel = (ushort)(NivelSeguridad + SDK.BS_USER_SECURITY_DEFAULT);

                        userHdr.bypassCard = (byte)TipoTarjeta;
                        userHdr.startDateTime = (uint)((FechaInicio - new DateTime(1970, 1, 1).Ticks) / 10000000);
                        userHdr.expireDateTime = (uint)((FechaFin - new DateTime(1970, 1, 1).Ticks) / 10000000);

                        userHdr.duress[0] = 0;
                        userHdr.duress[1] = 0;

                        if (Coaccion1)
                            userHdr.duress[0] = 0x01;
                        if (Coaccion2)
                            userHdr.duress[1] = 0x01;
                        if (ModoAutenticacion == 0)
                            userHdr.authMode = 0;
                        else
                            userHdr.authMode = (ushort)(ModoAutenticacion + SDK.BS_AUTH_FINGER_ONLY - 1);

                        string TarjetaID = "0";
                        int TarjetaIDPersonal = 0;
                        if (Tarjeta)
                            LeerTarjeta(ref TarjetaID, ref TarjetaIDPersonal);

                        userHdr.cardID = UInt32.Parse(TarjetaID, System.Globalization.NumberStyles.HexNumber);
                        userHdr.customID = (byte)TarjetaIDPersonal;

                        userHdr.accessGroupMask = UInt32.Parse(GrupoAcceso, System.Globalization.NumberStyles.HexNumber);

                        IntPtr userInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SDK.DSUserHdr)));
                        Marshal.StructureToPtr(userHdr, userInfo, true);

                        result = SDK.BS_EnrollUserDStation(HandleConexion, userInfo, Usuario.Dedo1Huella, Usuario.CaraHuella);
                        Marshal.FreeHGlobal(userInfo);
                        if (result != SDK.BS_SUCCESS)
                            return result;
                    }
                    break;

                case SDK.BS_DEVICE_XSTATION:
                    {
                        SDK.XSUserHdr userHdr = new SDK.XSUserHdr();

                        userHdr.name = new ushort[48];
                        userHdr.department = new ushort[48];
                        userHdr.password = new ushort[16];
                        userHdr.duress = new byte[10];
                        userHdr.reserved = new byte[2];
                        userHdr.fingerType = new byte[10];
                        userHdr.reserved1 = new byte[2];
                        userHdr.fingerChecksum = new uint[10];
                        userHdr.faceChecksum = new uint[5];
                        userHdr.reserved2 = new uint[10];

                        userHdr.ID = (uint)ID;
                        userHdr.startDateTime = (uint)((FechaInicio - new DateTime(1970, 1, 1).Ticks) / 10000000);
                        userHdr.expireDateTime = (uint)((FechaFin - new DateTime(1970, 1, 1).Ticks) / 10000000);

                        userHdr.adminLevel = (ushort)((NivelAdmin == 1) ? SDK.BS_USER_ADMIN : SDK.BS_USER_NORMAL);
                        userHdr.securityLevel = (ushort)(NivelSeguridad + SDK.BS_USER_SECURITY_DEFAULT);
                        userHdr.bypassCard = (byte)TipoTarjeta;

                        if (ModoAutenticacion == 0)
                            userHdr.authMode = 0;
                        else
                            userHdr.authMode = (ushort)(ModoAutenticacion + SDK.BS_AUTH_FINGER_ONLY - 1);

                        string TarjetaID = "0";
                        int TarjetaIDPersonal = 0;
                        if (Tarjeta)
                            LeerTarjeta(ref TarjetaID, ref TarjetaIDPersonal);

                        userHdr.cardID = UInt32.Parse(TarjetaID, System.Globalization.NumberStyles.HexNumber);
                        userHdr.customID = (byte)TarjetaIDPersonal;
                        userHdr.accessGroupMask = UInt32.Parse(GrupoAcceso, System.Globalization.NumberStyles.HexNumber);

                        IntPtr userInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SDK.XSUserHdr)));
                        Marshal.StructureToPtr(userHdr, userInfo, true);

                        result = SDK.BS_EnrollUserXStation(HandleConexion, userInfo);
                        Marshal.FreeHGlobal(userInfo);
                        if (result != SDK.BS_SUCCESS)
                            return result;
                    }
                    break;


                case SDK.BS_DEVICE_BIOSTATION2:
                    {
                        SDK.BS2UserHdr userHdr = new SDK.BS2UserHdr();

                        userHdr.name = new ushort[48];
                        userHdr.department = new ushort[48];
                        userHdr.password = new ushort[16];
                        userHdr.duress = new byte[10];
                        userHdr.reserved = new byte[2];
                        userHdr.fingerType = new byte[10];
                        userHdr.reserved1 = new byte[2];
                        userHdr.fingerChecksum = new uint[10];
                        userHdr.faceChecksum = new uint[5];
                        userHdr.reserved2 = new uint[10];

                        userHdr.disabled = 0;
                        userHdr.numOfFinger = (ushort)numOfFinger;
                        userHdr.fingerChecksum[0] = (ushort)fingerChecksum1;
                        userHdr.fingerChecksum[1] = (ushort)fingerChecksum2;

                        userHdr.ID = (uint)ID;
                        userHdr.adminLevel = (ushort)((NivelAdmin == 1) ? SDK.BS_USER_ADMIN : SDK.BS_USER_NORMAL);
                        userHdr.securityLevel = (ushort)(NivelSeguridad + SDK.BS_USER_SECURITY_DEFAULT);

                        userHdr.bypassCard = (byte)TipoTarjeta;
                        userHdr.startDateTime = (uint)((FechaInicio - new DateTime(1970, 1, 1).Ticks) / 10000000);
                        userHdr.expireDateTime = (uint)((FechaFin - new DateTime(1970, 1, 1).Ticks) / 10000000);

                        userHdr.duress[0] = 0;
                        userHdr.duress[1] = 0;

                        if (Coaccion1)
                            userHdr.duress[0] = 0x01;

                        if (Coaccion2)
                            userHdr.duress[1] = 0x01;

                        if (ModoAutenticacion == 0)
                            userHdr.authMode = 0;
                        else
                            userHdr.authMode = (ushort)(ModoAutenticacion + SDK.BS_AUTH_FINGER_ONLY - 1);

                        string TarjetaID = "0";
                        int TarjetaIDPersonal = 0;
                        if (Tarjeta)
                            LeerTarjeta(ref TarjetaID, ref TarjetaIDPersonal);
                        userHdr.cardID = UInt32.Parse(TarjetaID, System.Globalization.NumberStyles.HexNumber);
                        userHdr.customID = (byte)TarjetaIDPersonal;
                        userHdr.accessGroupMask = UInt32.Parse(GrupoAcceso, System.Globalization.NumberStyles.HexNumber);

                        IntPtr userInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SDK.BS2UserHdr)));
                        Marshal.StructureToPtr(userHdr, userInfo, true);

                        result = SDK.BS_EnrollUserBioStation2(HandleConexion, userInfo, Usuario.Dedo1Huella);
                        Marshal.FreeHGlobal(userInfo);

                        if (result != SDK.BS_SUCCESS)
                            return result;
                    }
                    break;
            }
            _Usuarios.Add(Usuario);
            return 0;
        }

        // Enviar los cambios de un usuario al dispositivo
        public int ModificarUsuario(int ID)
        {
            // TODO JP
            return 0;
        }

        // Eliminar un usuario del dispositivo
        public int EliminarUsuario(int ID)
        {
            int result = SDK.BS_DeleteUser(HandleConexion, (uint)ID);
            if (result != SDK.BS_SUCCESS)
                return result;
            _Usuarios.Remove(UsuarioPorID(ID));
            return 0;
        }

        // Obtener el ID del lector del Log
        private string ObtenerLectorID(uint LectorID)
        {
            if (LectorID == 0)
                return "local";
            else
                return LectorID.ToString();
        }


        // Obtener el log del dispositivo
        public int LeerLog(bool DiaActual, bool UltimaEntrada)
        {
            _Log.Clear();
            int startDate = 0;
            if (DiaActual)
                startDate = (int)((DateTime.Today.Ticks - new DateTime(1970, 1, 1).Ticks) / 10000000);
            int numOfLog = 0;
            int result = SDK.BS_GetLogCount(HandleConexion, ref numOfLog);
            if (result != SDK.BS_SUCCESS)
                return result;

            IntPtr logRecord = Marshal.AllocHGlobal(numOfLog * Marshal.SizeOf(typeof(SDK.BSLogRecord)));
            int logTotalCount = 0;
            int logCount = 0;
            if (UltimaEntrada)
            {
                IntPtr buf = new IntPtr(logRecord.ToInt32() + logTotalCount * Marshal.SizeOf(typeof(SDK.BSLogRecord)));
                result = SDK.BS_ReadLog(HandleConexion, startDate, 0, ref logCount, buf);
                if (result != SDK.BS_SUCCESS)
                {
                    Marshal.FreeHGlobal(logRecord);
                    return result;
                }
                logTotalCount += 1;
            }
            else
            {
                do
                {
                    IntPtr buf = new IntPtr(logRecord.ToInt32() + logTotalCount * Marshal.SizeOf(typeof(SDK.BSLogRecord)));
                    if (logTotalCount == 0)
                        result = SDK.BS_ReadLog(HandleConexion, startDate, 0, ref logCount, buf);
                    else
                        result = SDK.BS_ReadNextLog(HandleConexion, startDate, 0, ref logCount, buf);
                    if (result != SDK.BS_SUCCESS)
                    {
                        Marshal.FreeHGlobal(logRecord);
                        return result;
                    }
                    logTotalCount += logCount;

                } while (logCount == BS_MAX_LOG_ENTRIES);
            }

            for (int i = 0; i < logTotalCount; i++)
            {
                SDK.BSLogRecord record = (SDK.BSLogRecord)Marshal.PtrToStructure(new IntPtr(logRecord.ToInt32() + i * Marshal.SizeOf(typeof(SDK.BSLogRecord))), typeof(SDK.BSLogRecord));
                DateTime eventTime = new DateTime(1970, 1, 1).AddSeconds(record.eventTime);
                LogBioStar Log = new LogBioStar((int)record.userID, record.eventType, record.tnaEvent,
                    ObtenerLectorID(record.reserved), eventTime);
                _Log.Add(Log);
            }
            Marshal.FreeHGlobal(logRecord);
            return 0;
        }

        public int LeerLogIngresosExitosos()
        {
            _Log.Clear();
            int startDate = 0;
            int numOfLog = 0;
            int result = SDK.BS_GetLogCount(HandleConexion, ref numOfLog);
            if (result != SDK.BS_SUCCESS)
                return result;

            IntPtr logRecord = Marshal.AllocHGlobal(numOfLog * Marshal.SizeOf(typeof(SDK.BSLogRecord)));
            int logTotalCount = 0;
            int logCount = 0;
            do
            {
                IntPtr buf = new IntPtr(logRecord.ToInt32() + logTotalCount * Marshal.SizeOf(typeof(SDK.BSLogRecord)));
                if (logTotalCount == 0)
                    result = SDK.BS_ReadLog(HandleConexion, startDate, 0, ref logCount, buf);
                else
                    result = SDK.BS_ReadNextLog(HandleConexion, startDate, 0, ref logCount, buf);
                if (result != SDK.BS_SUCCESS)
                {
                    Marshal.FreeHGlobal(logRecord);
                    return result;
                }
                logTotalCount += logCount;

            } while (logCount == BS_MAX_LOG_ENTRIES);

            for (int i = 0; i < logTotalCount; i++)
            {
                SDK.BSLogRecord record = (SDK.BSLogRecord)Marshal.PtrToStructure(new IntPtr(logRecord.ToInt32() + i * Marshal.SizeOf(typeof(SDK.BSLogRecord))), typeof(SDK.BSLogRecord));
                DateTime eventTime = new DateTime(1970, 1, 1).AddSeconds(record.eventTime);
                if ((record.eventType == SDK.BE_EVENT_IDENTIFY_SUCCESS) || (record.tnaEvent == 0)) // Ingreso exitoso
                {
                    LogBioStar Log = new LogBioStar((int)record.userID, record.eventType, record.tnaEvent,
                        ObtenerLectorID(record.reserved), eventTime);
                    _Log.Add(Log);
                }
            }
            Marshal.FreeHGlobal(logRecord);
            return 0;
        }

        public int LeerLogIngresosEgresosExitosos()
        {
            _Log.Clear();
            int startDate = 0;
            int numOfLog = 0;
            int result = SDK.BS_GetLogCount(HandleConexion, ref numOfLog);
            if (result != SDK.BS_SUCCESS)
                return result;

            IntPtr logRecord = Marshal.AllocHGlobal(numOfLog * Marshal.SizeOf(typeof(SDK.BSLogRecord)));
            int logTotalCount = 0;
            int logCount = 0;
            do
            {
                IntPtr buf = new IntPtr(logRecord.ToInt32() + logTotalCount * Marshal.SizeOf(typeof(SDK.BSLogRecord)));
                if (logTotalCount == 0)
                    result = SDK.BS_ReadLog(HandleConexion, startDate, 0, ref logCount, buf);
                else
                    result = SDK.BS_ReadNextLog(HandleConexion, startDate, 0, ref logCount, buf);
                if (result != SDK.BS_SUCCESS)
                {
                    Marshal.FreeHGlobal(logRecord);
                    return result;
                }
                logTotalCount += logCount;

            } while (logCount == BS_MAX_LOG_ENTRIES);

            for (int i = 0; i < logTotalCount; i++)
            {
                SDK.BSLogRecord record = (SDK.BSLogRecord)Marshal.PtrToStructure(new IntPtr(logRecord.ToInt32() + i * Marshal.SizeOf(typeof(SDK.BSLogRecord))), typeof(SDK.BSLogRecord));
                DateTime eventTime = new DateTime(1970, 1, 1).AddSeconds(record.eventTime);
                if ((record.eventType == SDK.BE_EVENT_IDENTIFY_SUCCESS) && ((record.tnaEvent == 0) || (record.tnaEvent == 1))) // Ingreso o egreso exitoso
                {
                    LogBioStar Log = new LogBioStar((int)record.userID, record.eventType, record.tnaEvent,
                        ObtenerLectorID(record.reserved), eventTime);
                    _Log.Add(Log);
                }
            }
            Marshal.FreeHGlobal(logRecord);
            return 0;
        }

        public int Direccion { get { return _Direccion; } set { _Direccion = value; } }
        public string IP { get { return _IP; } set { _IP = value; } }
        public int ID { get { return _ID; } set { _ID = value; } }
        public int HandleConexion { get { return _HandleConexion; } set { _HandleConexion = value; } }
        public int Tipo { get { return _Tipo; } set { _Tipo = value; } }
        public string Descripcion { get { return _Descripcion; } set { _Descripcion = value; } }
        public bool Conectado { get { return _Conectado; } set { _Conectado = value; } }
        public ArrayList Usuarios { get { return _Usuarios; } }
        public ArrayList Log { get { return _Log; } }
    }

    public class BioStar
    {
        private int _HandleUDP;
        private ArrayList _Dispositivos;
        public const int MAX_DEVICE = 128;

        public BioStar()
        {
            IniciarUDP();
            _Dispositivos = new ArrayList();
        }

        // Iniciar el protocolo UDP (llamado automáticamente al crear el objeto)
        public int IniciarUDP()
        {
            int result = SDK.BS_InitSDK();
            if (result != SDK.BS_SUCCESS) return result;
            result = SDK.BS_OpenInternalUDP(ref _HandleUDP);
            return result;
        }

        // Generar la lista de dispositivos
        public int LeerDispositivos()
        {
            _Dispositivos.Clear();
            int m_NumOfDevice = 0;
            uint[] m_DeviceID = new uint[MAX_DEVICE];
            int[] m_DeviceType = new int[MAX_DEVICE];
            uint[] m_DeviceAddr = new uint[MAX_DEVICE];
            int result;

            result = SDK.BS_SearchDeviceInLAN(_HandleUDP, ref m_NumOfDevice, m_DeviceID, m_DeviceType, m_DeviceAddr);
            if (result != SDK.BS_SUCCESS)
                return result;

            for (int i = 0; i < m_NumOfDevice; i++)
            {
                string Descripcion = "";
                if (m_DeviceType[i] == SDK.BS_DEVICE_BIOSTATION)
                    Descripcion += "BioStation ";
                else if (m_DeviceType[i] == SDK.BS_DEVICE_DSTATION)
                    Descripcion += "D-Station ";
                else if (m_DeviceType[i] == SDK.BS_DEVICE_XSTATION)
                    Descripcion += "X-Station ";
                else if (m_DeviceType[i] == SDK.BS_DEVICE_BIOSTATION2)
                    Descripcion += "BioStation T2 ";
                else if (m_DeviceType[i] == SDK.BS_DEVICE_BEPLUS)
                    Descripcion += "BioEntry Plus ";
                else if (m_DeviceType[i] == SDK.BS_DEVICE_BIOLITE)
                    Descripcion += "BioLite Net ";
                else if (m_DeviceType[i] == SDK.BS_DEVICE_XPASS)
                    Descripcion += "Xpass ";
				else
					Descripcion += "Desconocido ";

                string IP = "";
                IP += (m_DeviceAddr[i] & 0xff) + ".";
                IP += ((m_DeviceAddr[i] >> 8) & 0xff) + ".";
                IP += ((m_DeviceAddr[i] >> 16) & 0xff) + ".";
                IP += ((m_DeviceAddr[i] >> 24) & 0xff);

                uint ID = m_DeviceID[i];
                int Tipo = m_DeviceType[i];

                DispositivoBioStar Dispositivo = new DispositivoBioStar(this, (int)m_DeviceAddr[i], IP, (int)ID, Tipo, Descripcion);
                Dispositivos.Add(Dispositivo);
            }
            return 0;
        }

        public ArrayList Dispositivos { get { return _Dispositivos; } }
        public int HandleUDP { get { return _HandleUDP; } }

    }
}
