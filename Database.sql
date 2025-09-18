CREATE TABLE IF NOT EXISTS departments (
  id INT AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(100) NOT NULL
) ENGINE=InnoDB;
 
CREATE TABLE IF NOT EXISTS employees (
  id INT AUTO_INCREMENT PRIMARY KEY,
  first_name VARCHAR(50) NOT NULL,
  last_name VARCHAR(50) NOT NULL,
  salary DECIMAL(10,2) NOT NULL DEFAULT 0.00,
  department_id INT DEFAULT NULL,
  FOREIGN KEY (department_id) REFERENCES departments(id) ON DELETE SET NULL
) ENGINE=InnoDB;
 
INSERT INTO departments (name) VALUES
('HR'),
('IT'),
('Sales');
 
INSERT INTO employees (first_name, last_name, salary, department_id) VALUES
('Иван', 'Иванов', 50000.00, 2),  -- IT
('Пётр', 'Петров', 45000.00, 2), -- IT
('Ольга', 'Сидорова', 40000.00, 1), -- HR
('Анна', 'Кузнецова', 42000.00, 1), -- HR
('Сергей', 'Смирнов', 38000.00, 3), -- Sales
('Елена', 'Федорова', 39000.00, 3); -- Sales