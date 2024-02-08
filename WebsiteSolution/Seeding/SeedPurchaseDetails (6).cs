
using Group5_FinalProject_v2.DAL;
using Group5_FinalProject_v2.Models;
using Group5_FinalProject_v2.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Group5_FinalProject_v2.Seeding
{
  


    public static class SeedPurchaseDetails
    {
        public static void SeedAllPurchaseDetails(AppDbContext db)
        {
            List<PurchaseDetail> AllPurchaseDetails = new List<PurchaseDetail>();





            AllPurchaseDetails.Add(new PurchaseDetail
           {
               Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 1),
               TransactionID = 1,
               PDSeat = PDSeat.A1,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 5m,
               PopcornPoints = 5,






                SeniorDiscount = false,
	            TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 1),
               TransactionID = 2,
               PDSeat = PDSeat.A2,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 1),
               TransactionID = 3,
               PDSeat = PDSeat.A3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 1),
               TransactionID = 4,
               PDSeat = PDSeat.A4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 1),
               TransactionID = 5,
               PDSeat = PDSeat.A5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 1),
               TransactionID = 6,
               PDSeat = PDSeat.B1,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 1),
               TransactionID = 7,
               PDSeat = PDSeat.B2,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 1),
               TransactionID = 8,
               PDSeat = PDSeat.B3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 1),
               TransactionID = 9,
               PDSeat = PDSeat.B4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 1),
               TransactionID = 10,
               PDSeat = PDSeat.B5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 2),
               TransactionID = 1,
               PDSeat = PDSeat.A1,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 10m,
               PopcornPoints = 10,






            SeniorDiscount = true,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 2),
               TransactionID = 2,
               PDSeat = PDSeat.A2,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 10m,
               PopcornPoints = 10,






            SeniorDiscount = true,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 2),
               TransactionID = 3,
               PDSeat = PDSeat.A3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 2),
               TransactionID = 4,
               PDSeat = PDSeat.A4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 2),
               TransactionID = 5,
               PDSeat = PDSeat.A5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 2),
               TransactionID = 6,
               PDSeat = PDSeat.B1,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 2),
               TransactionID = 7,
               PDSeat = PDSeat.B2,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 2),
               TransactionID = 8,
               PDSeat = PDSeat.B3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 2),
               TransactionID = 9,
               PDSeat = PDSeat.B4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 2),
               TransactionID = 10,
               PDSeat = PDSeat.B5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 3),
               TransactionID = 1,
               PDSeat = PDSeat.C2,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 3),
               TransactionID = 2,
               PDSeat = PDSeat.C3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 4),
               TransactionID = 1,
               PDSeat = PDSeat.C4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 4),
               TransactionID = 2,
               PDSeat = PDSeat.C5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 5),
               TransactionID = 1,
               PDSeat = PDSeat.A1,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 6),
               TransactionID = 1,
               PDSeat = PDSeat.A2,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 10m,
               PopcornPoints = 10,






            SeniorDiscount = true,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 7),
               TransactionID = 1,
               PDSeat = PDSeat.A3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 8),
               TransactionID = 1,
               PDSeat = PDSeat.A4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 9),
               TransactionID = 1,
               PDSeat = PDSeat.A5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 10),
               TransactionID = 1,
               PDSeat = PDSeat.B1,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 11),
               TransactionID = 1,
               PDSeat = PDSeat.B2,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 12),
               TransactionID = 1,
               PDSeat = PDSeat.B3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 13),
               TransactionID = 1,
               PDSeat = PDSeat.B4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 14),
               TransactionID = 1,
               PDSeat = PDSeat.B5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 15),
               TransactionID = 1,
               PDSeat = PDSeat.E1,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 16),
               TransactionID = 1,
               PDSeat = PDSeat.E2,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 17),
               TransactionID = 1,
               PDSeat = PDSeat.E3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 18),
               TransactionID = 1,
               PDSeat = PDSeat.E4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 19),
               TransactionID = 1,
               PDSeat = PDSeat.E5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 20),
               TransactionID = 1,
               PDSeat = PDSeat.C4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 21),
               TransactionID = 1,
               PDSeat = PDSeat.C5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 22),
               TransactionID = 1,
               PDSeat = PDSeat.D1,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 23),
               TransactionID = 1,
               PDSeat = PDSeat.A2,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 24),
               TransactionID = 1,
               PDSeat = PDSeat.A3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 25),
               TransactionID = 1,
               PDSeat = PDSeat.A4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 26),
               TransactionID = 1,
               PDSeat = PDSeat.A5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 27),
               TransactionID = 1,
               PDSeat = PDSeat.B1,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 28),
               TransactionID = 1,
               PDSeat = PDSeat.B2,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 29),
               TransactionID = 1,
               PDSeat = PDSeat.B3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 30),
               TransactionID = 1,
               PDSeat = PDSeat.B4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 31),
               TransactionID = 1,
               PDSeat = PDSeat.B5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 32),
               TransactionID = 1,
               PDSeat = PDSeat.E1,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 33),
               TransactionID = 1,
               PDSeat = PDSeat.E2,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 34),
               TransactionID = 1,
               PDSeat = PDSeat.E3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 35),
               TransactionID = 1,
               PDSeat = PDSeat.E4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 36),
               TransactionID = 1,
               PDSeat = PDSeat.E5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 37),
               TransactionID = 1,
               PDSeat = PDSeat.C4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 38),
               TransactionID = 1,
               PDSeat = PDSeat.C5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 39),
               TransactionID = 1,
               PDSeat = PDSeat.D1,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 39),
               TransactionID = 2,
               PDSeat = PDSeat.A2,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 39),
               TransactionID = 3,
               PDSeat = PDSeat.A3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 40),
               TransactionID = 1,
               PDSeat = PDSeat.A4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 40),
               TransactionID = 2,
               PDSeat = PDSeat.A5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 40),
               TransactionID = 3,
               PDSeat = PDSeat.B1,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 40),
               TransactionID = 4,
               PDSeat = PDSeat.B2,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 40),
               TransactionID = 5,
               PDSeat = PDSeat.B3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 40),
               TransactionID = 6,
               PDSeat = PDSeat.B4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 41),
               TransactionID = 1,
               PDSeat = PDSeat.B5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 41),
               TransactionID = 2,
               PDSeat = PDSeat.E1,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 42),
               TransactionID = 1,
               PDSeat = PDSeat.E2,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 42),
               TransactionID = 2,
               PDSeat = PDSeat.E3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 43),
               TransactionID = 1,
               PDSeat = PDSeat.E4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 43),
               TransactionID = 2,
               PDSeat = PDSeat.E5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 43),
               TransactionID = 3,
               PDSeat = PDSeat.C4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 43),
               TransactionID = 4,
               PDSeat = PDSeat.C5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 15m,
               PopcornPoints = 15,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 44),
               TransactionID = 1,
               PDSeat = PDSeat.B2,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 44),
               TransactionID = 2,
               PDSeat = PDSeat.B3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 44),
               TransactionID = 3,
               PDSeat = PDSeat.B4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 45),
               TransactionID = 1,
               PDSeat = PDSeat.B5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 46),
               TransactionID = 1,
               PDSeat = PDSeat.E1,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 46),
               TransactionID = 2,
               PDSeat = PDSeat.E2,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 47),
               TransactionID = 1,
               PDSeat = PDSeat.E3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 47),
               TransactionID = 2,
               PDSeat = PDSeat.E4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 48),
               TransactionID = 1,
               PDSeat = PDSeat.E5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 49),
               TransactionID = 1,
               PDSeat = PDSeat.E5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 12m,
               PopcornPoints = 12,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 50),
               TransactionID = 1,
               PDSeat = PDSeat.A4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 50),
               TransactionID = 2,
               PDSeat = PDSeat.E1,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 50),
               TransactionID = 3,
               PDSeat = PDSeat.E2,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 50),
               TransactionID = 4,
               PDSeat = PDSeat.E3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 50),
               TransactionID = 5,
               PDSeat = PDSeat.E4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 50),
               TransactionID = 6,
               PDSeat = PDSeat.E5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 50),
               TransactionID = 7,
               PDSeat = PDSeat.B3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 50),
               TransactionID = 8,
               PDSeat = PDSeat.B4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 50),
               TransactionID = 9,
               PDSeat = PDSeat.B5,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.One),
               TicketPrice = 5m,
               PopcornPoints = 5,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.CashCard,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 51),
               TransactionID = 1,
               PDSeat = PDSeat.C3,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 0m,
               PopcornPoints = -100,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.Points,
           }) ;



            AllPurchaseDetails.Add(new PurchaseDetail
           {
              Purchase = db.Purchases.FirstOrDefault(a => a.PurchaseID == 51),
               TransactionID = 2,
               PDSeat = PDSeat.C4,
               Schedule = db.Schedules.FirstOrDefault(a=>a.Theater == Theater.Two),
               TicketPrice = 0m,
               PopcornPoints = -100,






            SeniorDiscount = false,
	          TuesdayDiscount = false,
		        PaymentMethod = PaymentMethod.Points,
           }) ;

            //create a counter and flag to help with debugging
            int intTransactionDetailID = 0;
            String strTransactionDetailCustomer = "Start";


            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artistRatings
                foreach (PurchaseDetail seedPurchaseDetail in AllPurchaseDetails)
                {
                    //updates the counters to get info on where the problem is
                    intTransactionDetailID = seedPurchaseDetail.TransactionID;
                    //strTransactionDetailCustomer = seedTransactionDetails.AppUser.FirstName + seedTransactionDetails.AppUser.LastName;




                    //try to find the artistRating in the database based on whether there already exists and artist review with
                    //the same artist name and the same appuser's first + last name associated with it
                    PurchaseDetail dbPurchaseDetail = db.PurchaseDetails.FirstOrDefault(c => (c.TransactionID== seedPurchaseDetail.TransactionID) &&
                                                                                       (c.Purchase.PurchaseID == seedPurchaseDetail.Purchase.PurchaseID));


                    //if the artistRating isn't in the database, dbArtistRating will be null
                    if (dbPurchaseDetail == null)
                    {
                        //add the ArtistRating to the database
                        db.PurchaseDetails.Add(seedPurchaseDetail);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artistRating because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        // dbTransactionDetail.PurchaseID = seedTransactionDetails.PurchaseID;
                        dbPurchaseDetail.TransactionID = seedPurchaseDetail.TransactionID;
                        //dbPurchaseDetail.Movie = seedTransactionDetails.Movie;
                        //dbPurchaseDetail.DateTime = seedTransactionDetails.DateTime;
                        dbPurchaseDetail.PDSeat = seedPurchaseDetail.PDSeat;
                        //dbPurchaseDetail.Theater = seedPurchaseDetail.Theater;
                        dbPurchaseDetail.TicketPrice = seedPurchaseDetail.TicketPrice;
                        dbPurchaseDetail.PopcornPoints = seedPurchaseDetail.PopcornPoints;
                        dbPurchaseDetail.SeniorDiscount = seedPurchaseDetail.SeniorDiscount;
                        dbPurchaseDetail.TuesdayDiscount = seedPurchaseDetail.TuesdayDiscount;
                        dbPurchaseDetail.PaymentMethod = seedPurchaseDetail.PaymentMethod;






                        //you would add other fields here
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex) //something about adding to the database caused a problem
            {
                //create a new instance of the string builder to make building out
                //our message neater - we don't want a REALLY long line of code for this
                //so we break it up into several lines
                StringBuilder msg = new StringBuilder();


                msg.Append("There was an error adding the ");
                msg.Append(strTransactionDetailCustomer);
                msg.Append(" strTransactionDetailCustomer (TransactionDetailID = ");
                msg.Append(intTransactionDetailID);
                msg.Append(")");


                //have this method throw the exception to the calling method
                //this code wraps the exception from the database with the
                //custom message we built above. The original error from the
                //database becomes the InnerException
                throw new Exception(msg.ToString(), ex);
            }


        }
    }


}
