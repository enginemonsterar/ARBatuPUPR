using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using MonsterAR.Utility;
public class GameController : Singleton<GameController> {

	[SerializeField] private GameObject infoPanel;
	[SerializeField] private TextMeshProUGUI nameText;
	[SerializeField] private Text descText;

	private List<RockClassfication> rockClasses = new List<RockClassfication>();

	// Use this for initialization
	void Start () {
		AssignRockClassification();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTracking(int id){		
		infoPanel.SetActive(true);
		
		//Set Data
		nameText.text = rockClasses[id].GetName();
		descText.text = rockClasses[id].GetDescription();
	}

	public void OnLost(int id){		
		infoPanel.SetActive(false);
	}

	void AssignRockClassification(){
		rockClasses.Add(new RockClassfication(
			"Batuan Beku",
			"Batuan yang berasal dari magma yang mengalami pembekuan, bebatuan ini bisa terbentuk jauh di dalam lapisan atmosfer bumi, di celah-celah antar lapisan di dalam kulit bumi, atau terbentuk di permukaan bumi. "));		
		rockClasses.Add(new RockClassfication(
			"Batuan Metamorf",
			"Batuan metamorf adalah batuan yang mengalami transformasi dan perubahan bentuk dari tipe yang ada sebelumnya. Batuan metamorf biasanya tersingkap di permukaan bumi karena adanya erosi tanah atau pengangkatan. Batuan asal yang dikenai panas atau tekanan yang ekstrim akan mengalami perubahan fisika atau kimia yang besar. "));
		rockClasses.Add(new RockClassfication(
			"Batuan Sedimen",
			"Terbentuk sebagai hasil pemadatan endapan yang berupa bahan-bahan lepas yang terbawa oleh air, es, longsoran gravitasi, gerakan tanah, angin, atau adanya proses pembatuan dari pelapukan dan erosi tanah yang telah terbawa arus kemudian diendapkan, atau dari penguapan larutan kalsium karbonat, silica, garam, dan material lainnya. Batuan sedimen sangat banyak jumlahnya, mencapai 70 % dari bebatuan yang ada di seluruh permukaan bumi. "));
		rockClasses.Add(new RockClassfication(
			"Batuan Piroklastik",
			"Batuan ini dihasilkan dari proses pembatuan bahan-bahan yang dihembuskan dari pusat vulkanik selama masa erupsi yang memiliki sifat eksplosif. Struktur dari fragmennya bengkok dan terdeformasi, yang terjadi karena erupsi dari ledakan material yang berukuran debu yang dihembuskan ke udara. "));
		rockClasses.Add(new RockClassfication(
			"Batuan Fosil",
			"Terbentuk dari proses penghancuran peninggalan organisme yang pernah hidup, hal ini akan terjadi ketika tumbuhan atau hewan terkubur dalam kondisi lingkungan tanpa oksigen dan menjadi batu. Sisa-sisa hewan atau tanaman ini harus segera tertutup sedimen untuk menjadi fosil. Fosil yang paling umum adalah kerangka hewan seperti cangkang, gigi dan tulang. "));
	}

}
