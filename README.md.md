# ObstacleAoYin

Sebuah game 2D/3D sederhana berbasis Unity di mana pemain harus menghindari objek yang jatuh (obstacle). Dibangun sebagai project latihan untuk mempelajari collision detection, tagging system, dan game mechanics dasar di Unity.

## 🎮 Fitur

- **Obstacle Dropping** — Objek muncul dan jatuh secara otomatis setelah jeda waktu tertentu (`timeToWait`), lengkap dengan physics menggunakan Rigidbody.
- **Collision Detection** — Mendeteksi tabrakan antara obstacle dan Player, lalu memberi reaksi visual (perubahan warna) saat objek terkena hit.
- **Tag-based Logic** — Menggunakan sistem tag Unity (`Player`, `AoYin`) untuk membedakan objek mana yang perlu direspons.
- **Movement & Scoring** — Terdapat sistem pergerakan (`Mover.cs`) dan skor (`Scorer.cs`) untuk melacak progres pemain.

## 📁 Struktur Project

```
ObstacleAoYin/
├── Assets/
│   ├── Scripts/
│   │   ├── Dropper.cs      # Mengatur delay & drop obstacle (gravity, mesh visibility)
│   │   ├── ObjectHit.cs    # Deteksi collision & perubahan warna saat objek kena hit
│   │   ├── Mover.cs        # Logika pergerakan objek/Player
│   │   └── Scorer.cs       # Sistem penghitungan skor
│   ├── Materials/
│   └── Scenes/
│       └── SampleScene.unity
├── Packages/
├── ProjectSettings/
└── ObstacleAoYin.slnx
```

## 🛠️ Requirements

- [Unity Hub](https://unity.com/download) (disarankan versi LTS terbaru)
- Unity Editor (cek versi yang cocok di `ProjectSettings/ProjectVersion.txt` setelah clone)

## 🚀 Cara Menjalankan

1. Clone repository ini:
   ```bash
   git clone https://github.com/sleepydollx/ObstacleAoYin.git
   ```
2. Buka Unity Hub, pilih **Add project from disk**, lalu arahkan ke folder hasil clone.
3. Buka `Assets/Scenes/SampleScene.unity`.
4. Tekan tombol **Play** di Unity Editor untuk mencoba game.

## 📝 Catatan Pengembangan

- Pastikan setiap GameObject yang relevan (Player, obstacle) sudah punya **tag** yang sesuai (`Player`, `AoYin`, dll) di Inspector, karena logika collision sangat bergantung pada tag ini.
- Jika project menggunakan **URP/HDRP**, penggantian warna material perlu memakai `SetColor("_BaseColor", ...)`, bukan `material.color`, agar perubahan warna terlihat di runtime.

## 📌 Status

Project ini masih dalam tahap pengembangan/latihan.

## 📄 License

Belum ditentukan.
