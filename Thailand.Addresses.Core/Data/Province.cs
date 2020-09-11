using System.Collections.Generic;

using Thailand.Addresses.Core.Models;

namespace Thailand.Addresses.Core.Data {
    public class Province {
        public List<ProvinceModel> ProvinceData() {
            return new List<ProvinceModel> {
                new ProvinceModel { ProvinceId = 1, ProvinceCode = "10", ProvinceNameTh = "กรุงเทพมหานคร", ProvinceNameEn = "Bangkok", RegionId = 2 },
                new ProvinceModel { ProvinceId = 2, ProvinceCode = "11", ProvinceNameTh = "สมุทรปราการ", ProvinceNameEn = "Samut Prakan", RegionId = 2 },
                new ProvinceModel { ProvinceId = 3, ProvinceCode = "12", ProvinceNameTh = "นนทบุรี", ProvinceNameEn = "Nonthaburi", RegionId = 2 },
                new ProvinceModel { ProvinceId = 4, ProvinceCode = "13", ProvinceNameTh = "ปทุมธานี", ProvinceNameEn = "Pathum Thani", RegionId = 2 },
                new ProvinceModel { ProvinceId = 5, ProvinceCode = "14", ProvinceNameTh = "พระนครศรีอยุธยา", ProvinceNameEn = "Phra Nakhon Si Ayutthaya", RegionId = 2 },
                new ProvinceModel { ProvinceId = 6, ProvinceCode = "15", ProvinceNameTh = "อ่างทอง", ProvinceNameEn = "Ang Thong", RegionId = 2 },
                new ProvinceModel { ProvinceId = 7, ProvinceCode = "16", ProvinceNameTh = "ลพบุรี", ProvinceNameEn = "Lop Buri", RegionId = 2 },
                new ProvinceModel { ProvinceId = 8, ProvinceCode = "17", ProvinceNameTh = "สิงห์บุรี", ProvinceNameEn = "Sing Buri", RegionId = 2 },
                new ProvinceModel { ProvinceId = 9, ProvinceCode = "18", ProvinceNameTh = "ชัยนาท", ProvinceNameEn = "Chai Nat", RegionId = 2 },
                new ProvinceModel { ProvinceId = 10, ProvinceCode = "19", ProvinceNameTh = "สระบุรี", ProvinceNameEn = "Saraburi", RegionId = 2 },
                new ProvinceModel { ProvinceId = 11, ProvinceCode = "20", ProvinceNameTh = "ชลบุรี", ProvinceNameEn = "Chon Buri", RegionId = 5 },
                new ProvinceModel { ProvinceId = 12, ProvinceCode = "21", ProvinceNameTh = "ระยอง", ProvinceNameEn = "Rayong", RegionId = 5 },
                new ProvinceModel { ProvinceId = 13, ProvinceCode = "22", ProvinceNameTh = "จันทบุรี", ProvinceNameEn = "Chanthaburi", RegionId = 5 },
                new ProvinceModel { ProvinceId = 14, ProvinceCode = "23", ProvinceNameTh = "ตราด", ProvinceNameEn = "Trat", RegionId = 5 },
                new ProvinceModel { ProvinceId = 15, ProvinceCode = "24", ProvinceNameTh = "ฉะเชิงเทรา", ProvinceNameEn = "Chachoengsao", RegionId = 5 },
                new ProvinceModel { ProvinceId = 16, ProvinceCode = "25", ProvinceNameTh = "ปราจีนบุรี", ProvinceNameEn = "Prachin Buri", RegionId = 5 },
                new ProvinceModel { ProvinceId = 17, ProvinceCode = "26", ProvinceNameTh = "นครนายก", ProvinceNameEn = "Nakhon Nayok", RegionId = 2 },
                new ProvinceModel { ProvinceId = 18, ProvinceCode = "27", ProvinceNameTh = "สระแก้ว", ProvinceNameEn = "Sa Kaeo", RegionId = 5 },
                new ProvinceModel { ProvinceId = 19, ProvinceCode = "30", ProvinceNameTh = "นครราชสีมา", ProvinceNameEn = "Nakhon Ratchasima", RegionId = 3 },
                new ProvinceModel { ProvinceId = 20, ProvinceCode = "31", ProvinceNameTh = "บุรีรัมย์", ProvinceNameEn = "Buri Ram", RegionId = 3 },
                new ProvinceModel { ProvinceId = 21, ProvinceCode = "32", ProvinceNameTh = "สุรินทร์", ProvinceNameEn = "Surin", RegionId = 3 },
                new ProvinceModel { ProvinceId = 22, ProvinceCode = "33", ProvinceNameTh = "ศรีสะเกษ", ProvinceNameEn = "Si Sa Ket", RegionId = 3 },
                new ProvinceModel { ProvinceId = 23, ProvinceCode = "34", ProvinceNameTh = "อุบลราชธานี", ProvinceNameEn = "Ubon Ratchathani", RegionId = 3 },
                new ProvinceModel { ProvinceId = 24, ProvinceCode = "35", ProvinceNameTh = "ยโสธร", ProvinceNameEn = "Yasothon", RegionId = 3 },
                new ProvinceModel { ProvinceId = 25, ProvinceCode = "36", ProvinceNameTh = "ชัยภูมิ", ProvinceNameEn = "Chaiyaphum", RegionId = 3 },
                new ProvinceModel { ProvinceId = 26, ProvinceCode = "37", ProvinceNameTh = "อำนาจเจริญ", ProvinceNameEn = "Amnat Charoen", RegionId = 3 },
                new ProvinceModel { ProvinceId = 27, ProvinceCode = "39", ProvinceNameTh = "หนองบัวลำภู", ProvinceNameEn = "Nong Bua Lam Phu", RegionId = 3 },
                new ProvinceModel { ProvinceId = 28, ProvinceCode = "40", ProvinceNameTh = "ขอนแก่น", ProvinceNameEn = "Khon Kaen", RegionId = 3 },
                new ProvinceModel { ProvinceId = 29, ProvinceCode = "41", ProvinceNameTh = "อุดรธานี", ProvinceNameEn = "Udon Thani", RegionId = 3 },
                new ProvinceModel { ProvinceId = 30, ProvinceCode = "42", ProvinceNameTh = "เลย", ProvinceNameEn = "Loei", RegionId = 3 },
                new ProvinceModel { ProvinceId = 31, ProvinceCode = "43", ProvinceNameTh = "หนองคาย", ProvinceNameEn = "Nong Khai", RegionId = 3 },
                new ProvinceModel { ProvinceId = 32, ProvinceCode = "44", ProvinceNameTh = "มหาสารคาม", ProvinceNameEn = "Maha Sarakham", RegionId = 3 },
                new ProvinceModel { ProvinceId = 33, ProvinceCode = "45", ProvinceNameTh = "ร้อยเอ็ด", ProvinceNameEn = "Roi Et", RegionId = 3 },
                new ProvinceModel { ProvinceId = 34, ProvinceCode = "46", ProvinceNameTh = "กาฬสินธุ์", ProvinceNameEn = "Kalasin", RegionId = 3 },
                new ProvinceModel { ProvinceId = 35, ProvinceCode = "47", ProvinceNameTh = "สกลนคร", ProvinceNameEn = "Sakon Nakhon", RegionId = 3 },
                new ProvinceModel { ProvinceId = 36, ProvinceCode = "48", ProvinceNameTh = "นครพนม", ProvinceNameEn = "Nakhon Phanom", RegionId = 3 },
                new ProvinceModel { ProvinceId = 37, ProvinceCode = "49", ProvinceNameTh = "มุกดาหาร", ProvinceNameEn = "Mukdahan", RegionId = 3 },
                new ProvinceModel { ProvinceId = 38, ProvinceCode = "50", ProvinceNameTh = "เชียงใหม่", ProvinceNameEn = "Chiang Mai", RegionId = 1 },
                new ProvinceModel { ProvinceId = 39, ProvinceCode = "51", ProvinceNameTh = "ลำพูน", ProvinceNameEn = "Lamphun", RegionId = 1 },
                new ProvinceModel { ProvinceId = 40, ProvinceCode = "52", ProvinceNameTh = "ลำปาง", ProvinceNameEn = "Lampang", RegionId = 1 },
                new ProvinceModel { ProvinceId = 41, ProvinceCode = "53", ProvinceNameTh = "อุตรดิตถ์", ProvinceNameEn = "Uttaradit", RegionId = 1 },
                new ProvinceModel { ProvinceId = 42, ProvinceCode = "54", ProvinceNameTh = "แพร่", ProvinceNameEn = "Phrae", RegionId = 1 },
                new ProvinceModel { ProvinceId = 43, ProvinceCode = "55", ProvinceNameTh = "น่าน", ProvinceNameEn = "Nan", RegionId = 1 },
                new ProvinceModel { ProvinceId = 44, ProvinceCode = "56", ProvinceNameTh = "พะเยา", ProvinceNameEn = "Phayao", RegionId = 1 },
                new ProvinceModel { ProvinceId = 45, ProvinceCode = "57", ProvinceNameTh = "เชียงราย", ProvinceNameEn = "Chiang Rai", RegionId = 1 },
                new ProvinceModel { ProvinceId = 46, ProvinceCode = "58", ProvinceNameTh = "แม่ฮ่องสอน", ProvinceNameEn = "Mae Hong Son", RegionId = 1 },
                new ProvinceModel { ProvinceId = 47, ProvinceCode = "60", ProvinceNameTh = "นครสวรรค์", ProvinceNameEn = "Nakhon Sawan", RegionId = 2 },
                new ProvinceModel { ProvinceId = 48, ProvinceCode = "61", ProvinceNameTh = "อุทัยธานี", ProvinceNameEn = "Uthai Thani", RegionId = 2 },
                new ProvinceModel { ProvinceId = 49, ProvinceCode = "62", ProvinceNameTh = "กำแพงเพชร", ProvinceNameEn = "Kamphaeng Phet", RegionId = 2 },
                new ProvinceModel { ProvinceId = 50, ProvinceCode = "63", ProvinceNameTh = "ตาก", ProvinceNameEn = "Tak", RegionId = 4 },
                new ProvinceModel { ProvinceId = 51, ProvinceCode = "64", ProvinceNameTh = "สุโขทัย", ProvinceNameEn = "Sukhothai", RegionId = 2 },
                new ProvinceModel { ProvinceId = 52, ProvinceCode = "65", ProvinceNameTh = "พิษณุโลก", ProvinceNameEn = "Phitsanulok", RegionId = 2 },
                new ProvinceModel { ProvinceId = 53, ProvinceCode = "66", ProvinceNameTh = "พิจิตร", ProvinceNameEn = "Phichit", RegionId = 2 },
                new ProvinceModel { ProvinceId = 54, ProvinceCode = "67", ProvinceNameTh = "เพชรบูรณ์", ProvinceNameEn = "Phetchabun", RegionId = 2 },
                new ProvinceModel { ProvinceId = 55, ProvinceCode = "70", ProvinceNameTh = "ราชบุรี", ProvinceNameEn = "Ratchaburi", RegionId = 4 },
                new ProvinceModel { ProvinceId = 56, ProvinceCode = "71", ProvinceNameTh = "กาญจนบุรี", ProvinceNameEn = "Kanchanaburi", RegionId = 4 },
                new ProvinceModel { ProvinceId = 57, ProvinceCode = "72", ProvinceNameTh = "สุพรรณบุรี", ProvinceNameEn = "Suphan Buri", RegionId = 2 },
                new ProvinceModel { ProvinceId = 58, ProvinceCode = "73", ProvinceNameTh = "นครปฐม", ProvinceNameEn = "Nakhon Pathom", RegionId = 2 },
                new ProvinceModel { ProvinceId = 59, ProvinceCode = "74", ProvinceNameTh = "สมุทรสาคร", ProvinceNameEn = "Samut Sakhon", RegionId = 2 },
                new ProvinceModel { ProvinceId = 60, ProvinceCode = "75", ProvinceNameTh = "สมุทรสงคราม", ProvinceNameEn = "Samut Songkhram", RegionId = 2 },
                new ProvinceModel { ProvinceId = 61, ProvinceCode = "76", ProvinceNameTh = "เพชรบุรี", ProvinceNameEn = "Phetchaburi", RegionId = 4 },
                new ProvinceModel { ProvinceId = 62, ProvinceCode = "77", ProvinceNameTh = "ประจวบคีรีขันธ์", ProvinceNameEn = "Prachuap Khiri Khan", RegionId = 4 },
                new ProvinceModel { ProvinceId = 63, ProvinceCode = "80", ProvinceNameTh = "นครศรีธรรมราช", ProvinceNameEn = "Nakhon Si Thammarat", RegionId = 6 },
                new ProvinceModel { ProvinceId = 64, ProvinceCode = "81", ProvinceNameTh = "กระบี่", ProvinceNameEn = "Krabi", RegionId = 6 },
                new ProvinceModel { ProvinceId = 65, ProvinceCode = "82", ProvinceNameTh = "พังงา", ProvinceNameEn = "Phangnga", RegionId = 6 },
                new ProvinceModel { ProvinceId = 66, ProvinceCode = "83", ProvinceNameTh = "ภูเก็ต", ProvinceNameEn = "Phuket", RegionId = 6 },
                new ProvinceModel { ProvinceId = 67, ProvinceCode = "84", ProvinceNameTh = "สุราษฎร์ธานี", ProvinceNameEn = "Surat Thani", RegionId = 6 },
                new ProvinceModel { ProvinceId = 68, ProvinceCode = "85", ProvinceNameTh = "ระนอง", ProvinceNameEn = "Ranong", RegionId = 6 },
                new ProvinceModel { ProvinceId = 69, ProvinceCode = "86", ProvinceNameTh = "ชุมพร", ProvinceNameEn = "Chumphon", RegionId = 6 },
                new ProvinceModel { ProvinceId = 70, ProvinceCode = "90", ProvinceNameTh = "สงขลา", ProvinceNameEn = "Songkhla", RegionId = 6 },
                new ProvinceModel { ProvinceId = 71, ProvinceCode = "91", ProvinceNameTh = "สตูล", ProvinceNameEn = "Satun", RegionId = 6 },
                new ProvinceModel { ProvinceId = 72, ProvinceCode = "92", ProvinceNameTh = "ตรัง", ProvinceNameEn = "Trang", RegionId = 6 },
                new ProvinceModel { ProvinceId = 73, ProvinceCode = "93", ProvinceNameTh = "พัทลุง", ProvinceNameEn = "Phatthalung", RegionId = 6 },
                new ProvinceModel { ProvinceId = 74, ProvinceCode = "94", ProvinceNameTh = "ปัตตานี", ProvinceNameEn = "Pattani", RegionId = 6 },
                new ProvinceModel { ProvinceId = 75, ProvinceCode = "95", ProvinceNameTh = "ยะลา", ProvinceNameEn = "Yala", RegionId = 6 },
                new ProvinceModel { ProvinceId = 76, ProvinceCode = "96", ProvinceNameTh = "นราธิวาส", ProvinceNameEn = "Narathiwat", RegionId = 6 },
                new ProvinceModel { ProvinceId = 77, ProvinceCode = "97", ProvinceNameTh = "บึงกาฬ", ProvinceNameEn = "Bueng Kan", RegionId = 3 }
            };
        }
    }
}