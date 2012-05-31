using Robocode;
using core.infrastructure;

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
        }

        public override void OnBulletHit(BulletHitEvent evnt)
        {
            publisher.publish(evnt);
        }

        public override void OnBulletHitBullet(BulletHitBulletEvent evnt)
        {
            publisher.publish(evnt);
        }

        public override void OnBulletMissed(BulletMissedEvent evnt)
        {
            publisher.publish(evnt);
        }

        public override void OnDeath(DeathEvent evnt)
        {
            publisher.publish(evnt);
        }

        public override void OnHitByBullet(HitByBulletEvent evnt)
        {
            publisher.publish(evnt);
        }

        public override void OnHitRobot(HitRobotEvent evnt)
        {
            publisher.publish(evnt);
        }

        public override void OnHitWall(HitWallEvent evnt)
        {
            publisher.publish(evnt);
        }

        public override void OnRobotDeath(RobotDeathEvent evnt)
        {
            publisher.publish(evnt);
        }

        public override void OnScannedRobot(ScannedRobotEvent evnt)
        {
            publisher.publish(evnt);
        }

        public override void OnWin(WinEvent evnt)
        {
            publisher.publish(evnt);
        }

        public override void OnRoundEnded(RoundEndedEvent evnt)
        {
            publisher.publish(evnt);
        }

        public override void OnBattleEnded(BattleEndedEvent evnt)
        {
            publisher.publish(evnt);
        }

        public override bool IsAdjustGunForRobotTurn
        {
            get { return base.IsAdjustGunForRobotTurn; }
            set { base.IsAdjustGunForRobotTurn = value; }
        }
    }
}