using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace SendRTA
{
    public partial class SendRTA : Form
    {
        private readonly string _RTAKey;
        private readonly string _sourceId;
        private readonly string _platformTypeId;
        private int returnCode = 0;

        public SendRTA()
        {
            InitializeComponent();

            _RTAKey = ConfigurationManager.AppSettings["RTAKey"];
            _sourceId = ConfigurationManager.AppSettings["sourceId"];
            _platformTypeId = ConfigurationManager.AppSettings["platformTypeId"];

        }

        private void feedRTA_SendRTABatch(object sender, EventArgs e)
        {
            //Service reference to 		 	//http://localhost/TeleoptiWFM/RTA/TeleoptiRtaService.svc
            var rta = new RTA.TeleoptiRtaServiceClient();
            var batchId = DateTime.UtcNow;
            var externalUserStateBatch = new RTA.ExternalUserState[5];

            //Create one ExternalUserState and add a few agents to it
            externalUserStateBatch[0] = new RTA.ExternalUserState()
            {
                BatchId = batchId,
                IsLoggedOn = true,
                IsSnapshot = false,
                SecondsInState = 60,
                StateCode = "ADMIN",
                StateDescription = "Doing Admin stuff",
                Timestamp = DateTime.UtcNow,
                UserCode = "2001"
            };

            externalUserStateBatch[1] = new RTA.ExternalUserState()
            {
                BatchId = batchId,
                IsLoggedOn = true,
                IsSnapshot = false,
                SecondsInState = 60,
                StateCode = "EMAIL",
                StateDescription = "Working the email queue",
                Timestamp = DateTime.UtcNow,
                UserCode = "2002"
            };

            externalUserStateBatch[2] = new RTA.ExternalUserState()
            {
                BatchId = batchId,
                IsLoggedOn = true,
                IsSnapshot = false,
                SecondsInState = 60,
                StateCode = "IDLE",
                StateDescription = "Ready to take calls",
                Timestamp = DateTime.UtcNow,
                UserCode = "0063"
            };

            externalUserStateBatch[3] = new RTA.ExternalUserState()
            {
                BatchId = batchId,
                IsLoggedOn = true,
                IsSnapshot = false,
                SecondsInState = 60,
                StateCode = "InCall",
                StateDescription = "Currenty on a call",
                Timestamp = DateTime.UtcNow,
                UserCode = "2000"
            };

            externalUserStateBatch[4] = new RTA.ExternalUserState()
            {
                BatchId = batchId,
                IsLoggedOn = true,
                IsSnapshot = false,
                SecondsInState = 60,
                StateCode = "WEB",
                StateDescription = "Working the web chat",
                Timestamp = DateTime.UtcNow,
                UserCode = "0019"
            };

            //Save the batch the the Teleopti RTA service
            returnCode = rta.SaveBatchExternalUserState(
                _RTAKey,
                _platformTypeId,
                _sourceId,
                externalUserStateBatch);
        }

        private void feedRTA_SendRTASingleuser(object sender, EventArgs e)
        {
            var rta = new RTA.TeleoptiRtaServiceClient();
            returnCode = rta.SaveExternalUserState(
                _RTAKey,            //authenticationKey
                 "0238",            //userCode, e.i the ACD Login ID          
                 "WEB",             //stateCode, the RTA state using the identifier for the state
                 "Working the web chat",          //stateDescription, the RTA state using the friendly name/description
                 true,              //isLoggedOn
                 0,                 //secondsInState, not used
                 DateTime.UtcNow,   //timestamp
                 _platformTypeId,   //platformTypeId
                 _sourceId,         //sourceId
                 DateTime.UtcNow,   //batchId
                 false              //isSnapshot
                 );
        }

        private void feedRTA_SendRTASnapShot(object sender, EventArgs e)
        {
            var rta = new RTA.TeleoptiRtaServiceClient();
            var snapshotBatchId = DateTime.UtcNow;

            //Create the array that will hold all posts in the batch
            var externalUserStateBatchSnapShot = new RTA.ExternalUserState[2];

            //Create one ExternalUserState and add it to the array
            externalUserStateBatchSnapShot[0] = new RTA.ExternalUserState()
            {
                BatchId = snapshotBatchId,
                IsLoggedOn = true,
                IsSnapshot = true,
                SecondsInState = 60,
                StateCode = "WEB",
                StateDescription = "Working the web chat",
                Timestamp = DateTime.UtcNow,
                UserCode = "0085"
            };
            //Create a second ExternalUserState and add it to the array
            externalUserStateBatchSnapShot[1] = new RTA.ExternalUserState()
            {
                BatchId = snapshotBatchId,
                IsLoggedOn = true,
                IsSnapshot = true,
                SecondsInState = 60,
                StateCode = "InCall",
                StateDescription = "Talking",
                Timestamp = DateTime.UtcNow,
                UserCode = "2003"
            };

            //Save the batch
            returnCode = rta.SaveBatchExternalUserState(
                    _RTAKey,
                    _platformTypeId,
                    _sourceId,
                    externalUserStateBatchSnapShot);

            //Close the snapshot batch, this will logout everybody _not_ part of the Array externalUserStateBatchSnapShot[]
            returnCode = rta.SaveExternalUserState(
                _RTAKey,
                "",
                "",
                "",
                true,
                0,
                snapshotBatchId,
                _platformTypeId,
                _sourceId,
                snapshotBatchId,
                true
            );
        }
    }

}




