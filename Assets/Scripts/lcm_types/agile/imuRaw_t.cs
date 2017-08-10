/* LCM type definition class file
 * This file was automatically generated by lcm-gen
 * DO NOT MODIFY BY HAND!!!!
 */

using System;
using System.Collections.Generic;
using System.IO;
using LCM.LCM;
 
namespace agile
{
    public sealed class imuRaw_t : LCM.LCM.LCMEncodable
    {
        public long utime;
        public long timestampArduino;
        public double[] accel;
        public double[] gyro;
        public double[] magn;
        public double baro;
 
        public imuRaw_t()
        {
            accel = new double[3];
            gyro = new double[3];
            magn = new double[3];
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0x0b3895c41fc9d09dL;
 
        static imuRaw_t()
        {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("agile.imuRaw_t"))
                return 0L;
 
            classes.Add("agile.imuRaw_t");
            ulong hash = LCM_FINGERPRINT_BASE
                ;
            classes.RemoveAt(classes.Count - 1);
            return (hash<<1) + ((hash>>63)&1);
        }
 
        public void Encode(LCMDataOutputStream outs)
        {
            outs.Write((long) LCM_FINGERPRINT);
            _encodeRecursive(outs);
        }
 
        public void _encodeRecursive(LCMDataOutputStream outs)
        {
            outs.Write(this.utime); 
 
            outs.Write(this.timestampArduino); 
 
            for (int a = 0; a < 3; a++) {
                outs.Write(this.accel[a]); 
            }
 
            for (int a = 0; a < 3; a++) {
                outs.Write(this.gyro[a]); 
            }
 
            for (int a = 0; a < 3; a++) {
                outs.Write(this.magn[a]); 
            }
 
            outs.Write(this.baro); 
 
        }
 
        public imuRaw_t(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public imuRaw_t(LCMDataInputStream ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static agile.imuRaw_t _decodeRecursiveFactory(LCMDataInputStream ins)
        {
            agile.imuRaw_t o = new agile.imuRaw_t();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(LCMDataInputStream ins)
        {
            this.utime = ins.ReadInt64();
 
            this.timestampArduino = ins.ReadInt64();
 
            this.accel = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                this.accel[a] = ins.ReadDouble();
            }
 
            this.gyro = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                this.gyro[a] = ins.ReadDouble();
            }
 
            this.magn = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                this.magn[a] = ins.ReadDouble();
            }
 
            this.baro = ins.ReadDouble();
 
        }
 
        public agile.imuRaw_t Copy()
        {
            agile.imuRaw_t outobj = new agile.imuRaw_t();
            outobj.utime = this.utime;
 
            outobj.timestampArduino = this.timestampArduino;
 
            outobj.accel = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                outobj.accel[a] = this.accel[a];
            }
 
            outobj.gyro = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                outobj.gyro[a] = this.gyro[a];
            }
 
            outobj.magn = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                outobj.magn[a] = this.magn[a];
            }
 
            outobj.baro = this.baro;
 
            return outobj;
        }
    }
}

