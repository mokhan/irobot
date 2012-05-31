using Robocode;

namespace core
{
    public class RoboMom : Robot
    {
        readonly IPublishEvents publisher;

        public RoboMom(IPublishEvents publisher)
        {
            this.publisher = publisher;
        }

        public override void Run()
        {
            while(true)
            {
                TurnLeft(10);
                Ahead(5);
            }
        }

        public override void OnBulletHit(BulletHitEvent evnt)
        {
            publisher.Publish(evnt);
        }

        public override void OnBulletHitBullet(BulletHitBulletEvent evnt)
        {
            base.OnBulletHitBullet(evnt);
        }

        public override void OnBulletMissed(BulletMissedEvent evnt)
        {
            base.OnBulletMissed(evnt);
        }

        public override void OnDeath(DeathEvent evnt)
        {
            base.OnDeath(evnt);
        }

        public override void OnHitByBullet(HitByBulletEvent evnt)
        {
            base.OnHitByBullet(evnt);
        }

        public override void OnHitRobot(HitRobotEvent evnt)
        {
            base.OnHitRobot(evnt);
        }

        public override void OnHitWall(HitWallEvent evnt)
        {
            base.OnHitWall(evnt);
            TurnRight(180);
        }

        public override void OnRobotDeath(RobotDeathEvent evnt)
        {
            base.OnRobotDeath(evnt);
        }

        public override void OnScannedRobot(ScannedRobotEvent evnt)
        {
            base.OnScannedRobot(evnt);
            TurnGunLeft(Heading - evnt.Bearing);
            Fire(10);
        }

        public override void OnWin(WinEvent evnt)
        {
            base.OnWin(evnt);
        }

        public override void OnRoundEnded(RoundEndedEvent evnt)
        {
            base.OnRoundEnded(evnt);
        }

        public override void OnBattleEnded(BattleEndedEvent evnt)
        {
            base.OnBattleEnded(evnt);
        }

        public override bool IsAdjustGunForRobotTurn
        {
            get { return base.IsAdjustGunForRobotTurn; }
            set { base.IsAdjustGunForRobotTurn = value; }
        }
    }
}