use std::io;

fn main() {
    println!("Write amount: ");

    let mut amount = String::new(); 
    io::stdin().read_line(&mut amount).unwrap();
    let amount: f32 = amount.trim().parse::<f32>().unwrap();

    println!("(10kr, 5kr, 1kr, 0.5kr, 0.25kr)\n{:?}", calculate(amount));
}

fn calculate(amount: f32) -> [i32; 5] {
    let currency_values = [10., 5., 1., 0.5, 0.25];
    let mut result = [0, 0, 0, 0, 0];
    let mut remaining = amount;

    for (i, item) in currency_values.iter().enumerate() {
        result[i] = {
            let a = (remaining / item).floor();
            remaining -= item * a;
            a as i32
        }
    }

    result
}